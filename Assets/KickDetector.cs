using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1.Data;
using System;

public class KickDetector : MonoBehaviour {

    private Client _Client;

    public string LoginScene;
    private IAccountStatus _AccountStatus;

    // Use this for initialization
    void Start () {
        _Client = Client.Instance;
        if (_Client != null)
        {
            _Client.User.AccountStatusProvider.Supply += _AccountStatusProvider;
            _Client.User.AccountStatusProvider.Unsupply += _ToLeave;
        }
        
    }

    private void _ToLeave(IAccountStatus obj)
    {
        _ToLogin();
    }

    private void _AccountStatusProvider(IAccountStatus obj)
    {
        obj.KickEvent += _ToLogin;
        _AccountStatus = obj;
    }

    private void _ToLogin()
    {
        Application.LoadLevel(LoginScene);
    }

    void OnDestroy()
    {
        if(_Client != null)
        {
            _Client.User.AccountStatusProvider.Supply -= _AccountStatusProvider;
            _Client.User.AccountStatusProvider.Unsupply -= _ToLeave;
        }
        if (_AccountStatus != null)
            _AccountStatus.KickEvent -= _ToLogin;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
