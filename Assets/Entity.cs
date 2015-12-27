using System;
using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1.Data;
using UnityStandardAssets.Cameras;
using Vector2 = Regulus.CustomType.Vector2;

public class Entity : MonoBehaviour {
    private IVisible _Visible;
    public Transform Root;
    public Transform ProbeOrigin;
    public Transform CameraTarget;
    private Client _Client;

    private Animator _Animator;
    
    public float Trun;
    public float Speed;

    private float _ProbeLength;

    

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
        }

        if (_Client != null)
        {
            
            _Client.User.VisibleProvider.Unsupply -= _DestroyEntity;
        }
    }

    

    

    // Use this for initialization
    void Start () {
        _Client = Client.Instance;
        if (_Client != null)
        {

            
            _Client.User.VisibleProvider.Unsupply += _DestroyEntity;
        }


        if (ProbeOrigin == null)
        {
            ProbeOrigin = Root;
        }
        _ProbeLength = 1.0f;

        _Animator = GetComponentInChildren<Animator>();
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
        _UpdateAnimator();

        var offsetRotY =  Trun * UnityEngine.Time.deltaTime;
        Root.Rotate(new Vector3(0, offsetRotY, 0));
        Root.Translate(Vector3.right * Speed * UnityEngine.Time.deltaTime);
        
        Debug.DrawRay(ProbeOrigin.position , ProbeOrigin.right, Color.yellow , _ProbeLength);
    }

    public void SetVisible(Regulus.Project.ItIsNotAGame1.Data.IVisible visible)
    {
        if(_Visible != null)
            throw new Exception("重複設定.");
        _Visible = visible;
        _Visible.StatusEvent += _Move;

        
        _SetPosition(_Visible.Position);

        _SetCamera();
    }

    private void _ClearCamera()
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            if (cam != null)
            {
                cam.target = null;                
                Debug.Log("主角離鏡" + _Visible.Id);
            }
                
        }
    }
    private void _SetCamera()
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var cam = GameObject.FindObjectOfType<CameraFollow>();
            cam.target = CameraTarget;

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

        var eulerAngles = Root.rotation.eulerAngles;
        eulerAngles.y = status.Direction;
        Root.rotation = Quaternion.Euler(eulerAngles);

        if (_Animator != null)
        {
            _Animator.SetInteger("Status", (int)status.Status);
        }
    }

    private void _UpdateAnimator()
    {
        if (_Animator != null)
        {
            _Animator.SetInteger("Speed" , (int)Speed);
            _Animator.SetInteger("Trun", (int)Trun);
        }
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
