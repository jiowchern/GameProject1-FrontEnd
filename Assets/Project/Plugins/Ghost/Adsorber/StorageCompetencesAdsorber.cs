                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class StorageCompetencesAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IStorageCompetences>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences _StorageCompetences;                        
       
        public StorageCompetencesAdsorber()
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
            _Agent.Distributor.Attach<IStorageCompetences>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IStorageCompetences>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences GetGPI()
        {
            return _StorageCompetences;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences gpi)
        {
            _StorageCompetences = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences gpi)
        {
            EnableEvent.Invoke(false);
            
            _StorageCompetences = null;
        }
        
        public void Query()
        {
            if(_StorageCompetences != null)
            {
                _StorageCompetences.Query().OnValue += ( result ) =>{ QueryResult.Invoke(result);};
            }
        }

        public void QueryForId()
        {
            if(_StorageCompetences != null)
            {
                _StorageCompetences.QueryForId().OnValue += ( result ) =>{ QueryForIdResult.Invoke(result);};
            }
        }
        
        [System.Serializable]
        public class UnityQueryResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]> { }
        public UnityQueryResult QueryResult;
        

        [System.Serializable]
        public class UnityQueryForIdResult : UnityEngine.Events.UnityEvent<System.Guid> { }
        public UnityQueryForIdResult QueryForIdResult;
        
        
    }
}
                    