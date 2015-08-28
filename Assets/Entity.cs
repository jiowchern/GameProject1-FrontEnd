using System;
using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1.Data;
using UnityStandardAssets.Cameras;
using Vector2 = Regulus.CustomType.Vector2;

public class Entity : MonoBehaviour {
    private IVisible _Visible;
    private Vector3 _Velocity;
    private Client _Client;

    void OnDestroy()
    {
        if (_Visible != null)
        {
            _Visible.MoveEvent -= _Move;            
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

        _Velocity = Vector3.zero;
    }

    private void _DestroyEntity(IVisible obj)
    {
        _ClearCamera();
        if (obj.Id == _Visible.Id)
        {
            GameObject.Destroy(gameObject);
        }        
    }

    // Update is called once per frame
	void Update ()
	{
	    var delta = _Velocity * UnityEngine.Time.deltaTime;
	    var pos = transform.position + delta;
        _SetPosition(pos);
	}

    public void SetVisible(Regulus.Project.ItIsNotAGame1.Data.IVisible visible)
    {
        if(_Visible != null)
            throw new Exception("重複設定.");
        _Visible = visible;
        _Visible.MoveEvent += _Move;

        
        _SetPosition(_Visible.Position);

        _SetCamera();
    }

    private void _ClearCamera()
    {
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var autoCam = GameObject.FindObjectOfType<AutoCam>();
            if(autoCam != null)
                autoCam.SetTarget(null);
        }
    }
    private void _SetCamera()
    {
        
        
        if (EntityController.MainEntityId == _Visible.Id)
        {
            var autoCam = GameObject.FindObjectOfType<AutoCam>();
            autoCam.SetTarget(gameObject.transform);
        }
        
    }

    private void _SetPosition(Vector2 position)
    {
        var pos = new Vector3(position.X, 0, position.Y);
        _SetPosition(pos);
    }

    private void _Move(Vector2 position, Vector2 velocity)
    {        
        _SetPosition(position);

        _Velocity = new Vector3 (velocity.X , 0 , velocity.Y);
    }

    private void _SetPosition(Vector3 pos)
    {
        var y = Terrain.activeTerrain.SampleHeight(pos);
        pos.y = y;
        transform.position = pos;
    }
}
