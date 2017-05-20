                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class AccountCreatorAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IAccountCreator>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IAccountCreator> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IAccountCreator _AccountCreator;                        
       
        public AccountCreatorAdsorber()
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
            _Agent.Distributor.Attach<IAccountCreator>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IAccountCreator>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IAccountCreator GetGPI()
        {
            return _AccountCreator;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator gpi)
        {
            _AccountCreator = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator gpi)
        {
            EnableEvent.Invoke(false);
            
            _AccountCreator = null;
        }
        
        public void Create(Regulus.Project.ItIsNotAGame1.Data.Account account)
        {
            if(_AccountCreator != null)
            {
                _AccountCreator.Create(account).OnValue += ( result ) =>{ CreateResult.Invoke(result);};
            }
        }
        
        [System.Serializable]
        public class UnityCreateResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> { }
        public UnityCreateResult CreateResult;
        
        
    }
}
                    