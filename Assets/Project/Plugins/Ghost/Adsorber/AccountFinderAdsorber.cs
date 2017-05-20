                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class AccountFinderAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IAccountFinder>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IAccountFinder> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IAccountFinder _AccountFinder;                        
       
        public AccountFinderAdsorber()
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
            _Agent.Distributor.Attach<IAccountFinder>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IAccountFinder>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IAccountFinder GetGPI()
        {
            return _AccountFinder;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder gpi)
        {
            _AccountFinder = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder gpi)
        {
            EnableEvent.Invoke(false);
            
            _AccountFinder = null;
        }
        
        public void FindAccountByName(System.String id)
        {
            if(_AccountFinder != null)
            {
                _AccountFinder.FindAccountByName(id).OnValue += ( result ) =>{ FindAccountByNameResult.Invoke(result);};
            }
        }

        public void FindAccountById(System.Guid accountId)
        {
            if(_AccountFinder != null)
            {
                _AccountFinder.FindAccountById(accountId).OnValue += ( result ) =>{ FindAccountByIdResult.Invoke(result);};
            }
        }
        
        [System.Serializable]
        public class UnityFindAccountByNameResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Account> { }
        public UnityFindAccountByNameResult FindAccountByNameResult;
        

        [System.Serializable]
        public class UnityFindAccountByIdResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Account> { }
        public UnityFindAccountByIdResult FindAccountByIdResult;
        
        
    }
}
                    