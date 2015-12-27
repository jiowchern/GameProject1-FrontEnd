using System;
using UnityEngine;
using System.Collections;
using System.Net;
using Regulus.Project.ItIsNotAGame1;

using Regulus.Utility;

public class Login : MonoBehaviour
{
    public UnityEngine.UI.InputField Account;
    public UnityEngine.UI.InputField Password;

    public UnityEngine.UI.InputField IPAddress;
    public UnityEngine.UI.InputField Port;
    public UnityEngine.UI.Text Message;
    
    
    public string NextScene;
    private IUser _User;
    private Regulus.Utility.StageMachine _Machine;
    

    public Login()
    {
        _Machine = new StageMachine();
    }
    // Use this for initialization

    void OnDestroy()
    {
        _Machine.Termination();
    }

    void Update()
    {
        _Machine.Update();
    }

    void Start ()
	{
        if (Client.Instance != null)
        {
            _User = Client.Instance.User;            
        }
	}

    public void Verify()
    {
        var stage = new DisconnectStage(_User.Remoting.OnlineProvider);

        stage.DoneEvent += _ToConnect;

        _Machine.Push(stage);
    }

    private void _ToConnect()
    {
        string ip;
        IPAddress ipAddress;
        if (System.Net.IPAddress.TryParse(IPAddress.text, out ipAddress) == false)
        {
            _Error("無效的IP");
            return;
        }
            
        ip = IPAddress.text;


        int port;
        if (int.TryParse(Port.text, out port) == false)
        {
            _Error("無效的Port");
            return;
        }
            
        
        var stage = new ConnectStage(ip, port , _User.Remoting.ConnectProvider);

        stage.SuccessEvent += _ToVerify;
        stage.FailEvent += _ToConnectFail;

        _Machine.Push(stage);
    }

    private void _ToConnectFail()
    {
        _Error("連線失敗");
    }

    private void _ToVerify()
    {
        var stage = new VerifyStage(Account.text, Password.text , _User.VerifyProvider);

        stage.SuccessEvent += _ToLoadPlay;
        stage.FailEvent += _ToVerifyFail;
        
        _Machine.Push(stage);
    }

    private void _ToVerifyFail()
    {
        _Error("驗證失敗");
    }

    private void _ToLoadPlay()
    {
        Application.LoadLevel(NextScene);
    }

    private void _Error(string message)
    {
        Message.text = message;
    }
}
