using System;
using UnityEngine;
using System.Collections;

using Regulus.Extension;
using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Utility;

using UnityEditor;

using UnityStandardAssets.Cameras;
using Vector2 = Regulus.CustomType.Vector2;

public class Entity : MonoBehaviour {
    private IVisible _Visible;
    public Transform Root;
    public Transform ProbeOrigin;
    public Transform NormalCameraTarget;
    public Transform BattleCameraTarget;
    public Transform CenterCameraTarget;
    private Client _Client;

    public TalkReceiver Talker;

    public Animator Avatar;
    
    public float Trun;

    public float Speed;

    private float _ProbeLength;

    private float _BeginSpeed;
    private float _EndSpeed;

    private float _SpeedStep;

    private float _BeginTrun;

    private float _EndTrun;

    private float _TrunStep;

    private float _LongIdleTime;

    public ACTOR_STATUS_TYPE Status;

    private Regulus.Utility.TimeCounter _DeltaTime;

    private Light _Light;

    private Vector3 SkillOffset;

    public Entity()
    {
        _DeltaTime = new TimeCounter();
    }
    public Guid Id
    {
        get
        {
            if (_Visible != null)
                return _Visible.Id;
            return Guid.Empty;
        }
    }

    void OnDestroy()
    {
        if (_Visible != null)
        {            
            _Visible.StatusEvent -= _Move;
            _Visible.TalkMessageEvent -= _ShowMessage;
        }

        if (_Client != null)
        {
            _Client.User.BattleCastControllerProvider.Supply -= _InBattle;
            _Client.User.BattleCastControllerProvider.Unsupply -= _OutBattle;
            _Client.User.VisibleProvider.Unsupply -= _DestroyEntity;
        }
    }

    private void _ShowMessage(string obj)
    {
        Talker.Show(obj);
    }

    // Use this for initialization
    void Start ()
    {
        _Light =  GetComponentInChildren<Light>();
        _Client = Client.Instance;
        if (_Client != null)
        {
            _Client.User.VisibleProvider.Unsupply += _DestroyEntity;
            _Client.User.BattleCastControllerProvider.Supply += _InBattle;
            _Client.User.BattleCastControllerProvider.Unsupply += _OutBattle;
        }


        if (ProbeOrigin == null)
        {
            ProbeOrigin = Root;
        }
        _ProbeLength = 1.0f;

        
    }

    private void _OutBattle(ICastSkill obj)
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            cam.Watchtarget = NormalCameraTarget;
            cam.CenterTarget = CenterCameraTarget;
        }
    }

    private void _InBattle(ICastSkill obj)
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            cam.Watchtarget = BattleCameraTarget;
            cam.CenterTarget = CenterCameraTarget;
        }
    }

    private void _DestroyEntity(IVisible obj)
    {        
        if (obj.Id == _Visible.Id)
        {
            _ClearCamera();
            GameObject.Destroy(gameObject);
        }        
    }

    // Update is called once per frame
	void Update ()
	{
	    var delta = _DeltaTime.Second;
        _DeltaTime.Reset();
        _UpdateAnimator();

        var offsetRotY =  Trun * delta;
        
	    
        Root.Rotate(new Vector3(0, offsetRotY, 0));
        Root.Translate( Vector3.right * Speed * delta);
	    Root.position = Root.position + (SkillOffset * delta);

        //Debug.DrawRay(ProbeOrigin.position , ProbeOrigin.right, Color.yellow , _ProbeLength);

	    if (_Light != null && _Visible != null)
	    {
	        _Light.range = _Visible.View;
            if(IsMainActor())
	            RenderSettings.fogEndDistance = _Visible.View;
	    }
        
    }

    public void SetVisible(Regulus.Project.ItIsNotAGame1.Data.IVisible visible)
    {
        if(_Visible != null)
            throw new Exception("重複設定.");
        _Visible = visible;        
        _Visible.StatusEvent += _Move;
        _Visible.TalkMessageEvent += _ShowMessage;
        _Visible.QueryStatus();


        _SetPosition(_Visible.Position);

        _SetCamera();

        _SetAvatarEquipments();
    }

    private void _SetAvatarEquipments()
    {
        var  aes  = gameObject.GetComponentsInChildren < AvatarEquipment>();
        foreach (var avatarEquipment in aes)
        {
            avatarEquipment.SetId(_Visible);
        }
    }

    

    public bool IsMainActor()
    {
        if(_Visible != null)
            return EntityController.MainEntityId == _Visible.Id;
        return false;
    }
    private void _ClearCamera()
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            if (cam != null)
            {
                cam.Watchtarget = null;
                cam.CenterTarget = null;
            }
            Debug.Log("主角離鏡" + _Visible.Id);
        }
    }
    private void _SetCamera()
    {

        
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            cam.Watchtarget = NormalCameraTarget;
            cam.CenterTarget = CenterCameraTarget;
            Debug.Log("主角入鏡" + _Visible.Id);
        }

        
    }

    private void _SetPosition(Vector2 position)
    {
        var pos = new Vector3(position.X, 0, position.Y);
        _SetPosition(pos);
    }

    private void _Move(VisibleStatus status)
    {        
        _SetPosition(status.StartPosition);
        
        Speed = status.Speed;        
        Trun = status.Trun;
        SkillOffset = new Vector3(status.SkillOffect.X , 0 , status.SkillOffect.Y); 

        var eulerAngles = Root.rotation.eulerAngles;
        eulerAngles.y = status.Direction;
        Root.rotation = Quaternion.Euler(eulerAngles);

        Status = status.Status;

        if (Avatar != null)
        {
            _BeginSpeed = Avatar.GetFloat("Speed");
            _EndSpeed = Speed;
            _SpeedStep = 0.0f;

            _BeginTrun = Avatar.GetFloat("Trun");
            
            _EndTrun = Trun > 0.0f ? 1 : Trun < 0.0f ? -1 : 0 ;            
            _TrunStep = 0.0f;
            
            if (Status == ACTOR_STATUS_TYPE.DAMAGE1)
            {
                Avatar.SetTrigger("Damage1");
            }
            else if (Status == ACTOR_STATUS_TYPE.KNOCKOUT1)
            {
                Avatar.SetTrigger("Knockout");
            }
            else if (Status == ACTOR_STATUS_TYPE.GUARD_IMPACT)
            {
                Avatar.SetTrigger("GuardImpact");
            }
            else if (Status == ACTOR_STATUS_TYPE.CHEST_OPEN)
            {
                Avatar.SetBool("Open" , true);                
            }            
            else if (Status == ACTOR_STATUS_TYPE.NORMAL_IDLE && Speed == 0.0f)
            {
                ResetLongIdle();
            }
        }
    }

    public void ResetLongIdle()
    {
        _LongIdleTime = Regulus.Utility.Random.Instance.NextFloat(3.0f, 10.0f);
    }
    private void _UpdateAnimator()
    {
        if (Avatar != null)
        {
            var deltaTime = UnityEngine.Time.deltaTime;
            if (_LongIdleTime < 0.0f && Status == ACTOR_STATUS_TYPE.NORMAL_IDLE && Speed == 0.0f)
            {
                Avatar.SetTrigger("LongIdle");
                _LongIdleTime = 0.0f;
            }
            else if(_LongIdleTime > 0.0f)
            {
                _LongIdleTime -= deltaTime;
            }

            _SpeedStep += deltaTime * 2.50f;
            _TrunStep += deltaTime * 5.0f;

            Avatar.SetFloat("Speed", Mathf.Lerp(_BeginSpeed, _EndSpeed, _SpeedStep));

            Avatar.SetFloat("Trun", Mathf.Lerp(_BeginTrun, _EndTrun, _TrunStep));

            Avatar.SetInteger("Status", (int)Status);
            
        }
    }

    private float _GetTargetSpeed()
    {
        return 0.0f;

    }

    private void _SetPosition(Vector3 pos)
    {
        if(Terrain.activeTerrain != null)
        {
            var y = Terrain.activeTerrain.SampleHeight(pos);
            pos.y = y;
        }
        
        Root.position = pos;
        
    }

    public Guid GetExploreTarget()
    {
        
        var hits = Physics.RaycastAll(ProbeOrigin.position, ProbeOrigin.right, _ProbeLength);
        foreach (var hit in hits)
        {
            
            var entity = hit.collider.transform.parent.GetComponent<Entity>();
            if (entity != null)
            {
                Debug.Log("探索目標" + entity.Id);
                return entity.Id;
            }
        }
        Debug.Log("沒有探索目標");
        return Guid.Empty;
    }
}

