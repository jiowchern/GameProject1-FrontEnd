using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1.Data;
using System;

public class EntityController : MonoBehaviour
{
	public static Guid MainEntityId { get; private set; }
	private Client _Client;
	private IPlayerProperys _PlayerProperys;
	private IMoveController _MoveController;

	void OnDestroy()
	{
		if (_Client != null)
		{
			_Client.User.PlayerProperysProvider.Supply -= _SetPlayer;
			_Client.User.PlayerProperysProvider.Unsupply -= _ClearPlayer;
			_Client.User.MoveControllerProvider.Supply -= _SetController;
			_Client.User.MoveControllerProvider.Unsupply -= _ClearController;
		}
	}

	

	// Use this for initialization
	void Start ()
	{
		_Client = Client.Instance;
		if (_Client != null)
		{
			_Client.User.MoveControllerProvider.Supply += _SetController;
			_Client.User.MoveControllerProvider.Unsupply += _ClearController;
			_Client.User.PlayerProperysProvider.Supply += _SetPlayer;
			_Client.User.PlayerProperysProvider.Unsupply += _ClearPlayer;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (_MoveController == null)
			return;


		if (Input.GetKey(KeyCode.LeftShift))
		{
			if (Input.GetKey(KeyCode.W))
			{
				_MoveController.Forward();
			}	        
		}
		else
		{
			if (Input.GetKey(KeyCode.W))
			{
				_MoveController.RunForward();
			}

		}


		if (Input.GetKeyDown(KeyCode.W))
		{
			if(Input.GetKey(KeyCode.LeftShift))
			{
				_MoveController.RunForward();
			}
			else
				_MoveController.Forward();
		}
		


		if (Input.GetKeyDown(KeyCode.S))
		{
			
			_MoveController.Backward();
			
		}

		if (Input.GetKeyDown(KeyCode.A) )
		{
			_MoveController.TrunLeft();            

		}

		if (Input.GetKeyDown(KeyCode.D) )
		{
			_MoveController.TrunRight();            
		}

		if(Input.GetKeyUp(KeyCode.W) ||
			Input.GetKeyUp(KeyCode.S)            )
		{
			_MoveController.StopMove();
			
		}

		if(Input.GetKeyUp(KeyCode.A) ||
				Input.GetKeyUp(KeyCode.D))
		{
			_MoveController.StopTrun();            
		}
	}

	private void _ClearController(IMoveController obj)
	{
		
		_MoveController = null;
	}

	private void _SetController(IMoveController obj)
	{
		_MoveController = obj;
		
	}

	private void _ClearPlayer(IPlayerProperys obj)
	{
		MainEntityId = Guid.Empty;
		_PlayerProperys = null;
	}

	private void _SetPlayer(IPlayerProperys obj)
	{
		MainEntityId = obj.Id;
		_PlayerProperys = obj;
		Debug.Log("取得主角" + MainEntityId);
	}

	public static bool IsMainEntity(IVisible visible)
	{
		if (visible == null)
			return false;
		return visible.Id == MainEntityId;
	}
}
