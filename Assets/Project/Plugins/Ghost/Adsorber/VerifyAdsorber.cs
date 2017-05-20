                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class VerifyAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IVerify>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IVerify> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IVerify _Verify;                        
       
        public VerifyAdsorber()
        {
            _Machine = new Regulus.Utility.StageMachine();
        }

        void Start()
        {
            _Machine.Push(new Regulus.Utility.SimpleStage(_ScanEnter, _ScanLeave, _ScanUpdate));
        }

        private void _ScanUpdate()
        {
            var agents = UnityEngine.GameObject.FindObjectsOfType<global::Regulus.Project.ItIsNotAGame.Data.Agent>();
            _Agent = agents.FirstOrDefault(d => string.IsNullOrEmpty(d.Name) == false && d.Name == Agent);
            if(_Agent != null)
            {
                _Machine.Push(new Regulus.Utility.SimpleStage(_DispatchEnter, _DispatchLeave));
            }            
        }

        private void _DispatchEnter()
        {
            _Agent.Distributor.Attach<IVerify>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IVerify>(this);
        }

        private void _ScanLeave()
        {

        }


        private void _ScanEnter()
        {

        }

        void Update()
        {
            _Machine.Update();
        }

        void OnDestroy()
        {
            _Machine.Termination();
        }

        public Regulus.Project.ItIsNotAGame1.Data.IVerify GetGPI()
        {
            return _Verify;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IVerify gpi)
        {
            _Verify = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IVerify gpi)
        {
            EnableEvent.Invoke(false);
            
            _Verify = null;
        }
        
        public void Login(System.String id,System.String password)
        {
            if(_Verify != null)
            {
                _Verify.Login(id,password).OnValue += ( result ) =>{ LoginResult.Invoke(result);};
            }
        }
        
        [System.Serializable]
        public class UnityLoginResult : UnityEngine.Events.UnityEvent<System.Boolean> { }
        public UnityLoginResult LoginResult;
        
        
    }
}
                    