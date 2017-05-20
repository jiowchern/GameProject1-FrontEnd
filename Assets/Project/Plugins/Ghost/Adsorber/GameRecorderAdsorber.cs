                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class GameRecorderAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IGameRecorder>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IGameRecorder> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IGameRecorder _GameRecorder;                        
       
        public GameRecorderAdsorber()
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
            _Agent.Distributor.Attach<IGameRecorder>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IGameRecorder>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IGameRecorder GetGPI()
        {
            return _GameRecorder;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder gpi)
        {
            _GameRecorder = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder gpi)
        {
            EnableEvent.Invoke(false);
            
            _GameRecorder = null;
        }
        
        public void Load(System.Guid account_id)
        {
            if(_GameRecorder != null)
            {
                _GameRecorder.Load(account_id).OnValue += ( result ) =>{ LoadResult.Invoke(result);};
            }
        }

        public void Save(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord game_player_record)
        {
            if(_GameRecorder != null)
            {
                _GameRecorder.Save(game_player_record);
            }
        }
        
        [System.Serializable]
        public class UnityLoadResult : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord> { }
        public UnityLoadResult LoadResult;
        
        
    }
}
                    