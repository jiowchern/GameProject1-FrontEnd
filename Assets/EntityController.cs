using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1.Data;
using System;

public class EntityController : MonoBehaviour
{
    public static Guid MainEntityId { get; private set; }
    private Client _Client;
    private IController _Controller;

    void OnDestroy()
    {
        if (_Client != null)
        {
            _Client.User.ControllerProvider.Supply -= _SetController;
            _Client.User.ControllerProvider.Unsupply -= _ClearController;
        }
    }

    // Use this for initialization
    void Start ()
    {
        _Client = Client.Instance;
        if (_Client != null)
        {
            _Client.User.ControllerProvider.Supply += _SetController;
            _Client.User.ControllerProvider.Unsupply += _ClearController;
        }
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (_Controller == null)
	        return;
	    if (Input.GetKeyDown(KeyCode.W))
	    {
	        _Controller.Move(0);
	    }

	    if (Input.GetKeyUp(KeyCode.S))
	    {
            _Controller.Move(180);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _Controller.Move(-90);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _Controller.Move(90);
        }
	    if(Input.GetKeyUp(KeyCode.Space))
	    {
            _Controller.Stop();
        }
    }

    private void _ClearController(IController obj)
    {
        MainEntityId = Guid.Empty;
        _Controller = null;
    }

    private void _SetController(IController obj)
    {
        _Controller = obj;
        MainEntityId = _Controller.Id;
    }
}
