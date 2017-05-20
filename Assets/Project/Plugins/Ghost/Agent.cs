
using System;

using Regulus.Utility;

using UnityEngine;


namespace Regulus.Project.ItIsNotAGame.Data{ 
    public abstract class Agent : MonoBehaviour
    {
        private Regulus.Remoting.Unity.Distributor _Distributor ;
        public Regulus.Remoting.Unity.Distributor Distributor { get{ return _Distributor ; } }
        private readonly Regulus.Utility.Updater _Updater;

        private Regulus.Remoting.IAgent _Agent;
        public string Name;
        public Agent()
        {            
            _Updater = new Updater();
        }
        public abstract Regulus.Remoting.IAgent _GetAgent();
        void Start()   
        {
            _Agent = _GetAgent();
            _Distributor  = new Regulus.Remoting.Unity.Distributor(_Agent);
            _Updater.Add(_Agent);
        }
        // Use this for initialization
        public void Connect(string ip,int port)
        {
            _Agent.Connect(ip, port).OnValue += _ConnectResult;
        }

        private void _ConnectResult(bool obj)
        {
            ConnectEvent.Invoke(obj);
        }

        void OnDestroy()
        {
            _Updater.Shutdown();
        }

       
        // Update is called once per frame
        void Update()
        {
            _Updater.Working();
        }
        [Serializable]
        public class UnityAgentConnectEvent : UnityEngine.Events.UnityEvent<bool>{}

        public UnityAgentConnectEvent ConnectEvent;
    }
}
