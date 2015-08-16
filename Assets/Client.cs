using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using Regulus.Framework;
using Regulus.Project.ItIsNotAGame1;
using Regulus.Project.ItIsNotAGame1.Game.Play;
using Regulus.Utility;

public class Client : MonoBehaviour
{

    public static Client Instance {
        get { return GameObject.FindObjectOfType<Client>();  }
    }
    public enum MODE
    {
        STANDALONE,REMOTING
    }

    public MODE Mode;
    public Console Console;
    private Client<IUser> _Client;
    private Regulus.Utility.Updater _Updater;

    public Client()
    {
        _Updater = new Updater();
        
    }
    // Use this for initialization
	void Start ()
	{
        var client = new Regulus.Framework.Client<Regulus.Project.ItIsNotAGame1.IUser>(Console, Console);
        client.ModeSelectorEvent += _ToMode;
        _Client = client;
	    _Updater.Add(_Client);
        
	}

    private void _ToMode(GameModeSelector<IUser> selector)
    {
        UserProvider<IUser> provider;
        if (Mode == MODE.REMOTING)
        {
            selector.AddFactoty("r", new RemotingUserFactory());
            provider = selector.CreateUserProvider("r");
        }
        else
        {
            var feature = new Regulus.Project.ItIsNotAGame1.Game.DummyFrature();
            var center = new Center(feature, feature);
            
            _Updater.Add(center);
            selector.AddFactoty("s", new StandaloneUserFactory(center));
            provider = selector.CreateUserProvider("s");
        }

        var user = provider.Spawn("user");
        provider.Select("user");

        User = user;

    }

    public IUser User { get; private set; }

    // Update is called once per frame
	void Update () {
	    _Updater.Working();
	}

    void OnDestroy()
    {
        _Updater.Shutdown();
    }
}
