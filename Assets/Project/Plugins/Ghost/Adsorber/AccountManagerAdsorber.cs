                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class AccountManagerAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IAccountManager>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IAccountManager> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IAccountManager _AccountManager;                        
       
        public AccountManagerAdsorber()
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
            _Agent.Distributor.Attach<IAccountManager>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IAccountManager>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IAccountManager GetGPI()
        {
            return _AccountManager;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IAccountManager gpi)
        {
            _AccountManager = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IAccountManager gpi)
        {
            EnableEvent.Invoke(false);
            
            _AccountManager = null;
        }
        
        public void Create(Regulus.Project.ItIsNotAGame1.Data.Account account)
        {
            if(_AccountManager != null)
            {
                _AccountManager.Create(account).OnValue += ( result ) =>{ CreateResult.Invoke(result);};
            }
        }

        public void QueryAllAccount()
        {
            if(_AccountManager != null)
            {
                _AccountManager.QueryAllAccount().OnValue += ( result ) =>{ QueryAllAccountResult.Invoke(result);};
            }
        }

        public void Delete(System.String account)
        {
            if(_AccountManager != null)
            {
                _AccountManager.Delete(account).OnValue += ( result ) =>{ DeleteResult.Invoke(result);};
            }
        }

        public void Update(Regulus.Project.ItIsNotAGame1.Data.Account account)
        {
            if(_AccountManager != null)
            {
                _AccountManager.Update(account).OnValue += ( result ) =>{ UpdateResult.Invoke(result);};
            }
        }
        
        [System.Serializable]
        public class UnityCreateResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> { }
        public UnityCreateResult CreateResult;
        

        [System.Serializable]
        public class UnityQueryAllAccountResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Account[]> { }
        public UnityQueryAllAccountResult QueryAllAccountResult;
        

        [System.Serializable]
        public class UnityDeleteResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> { }
        public UnityDeleteResult DeleteResult;
        

        [System.Serializable]
        public class UnityUpdateResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> { }
        public UnityUpdateResult UpdateResult;
        
        
    }
}
                    