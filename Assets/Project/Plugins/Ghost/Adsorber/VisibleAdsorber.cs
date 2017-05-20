                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class VisibleAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IVisible>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IVisible> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IVisible _Visible;                        
       
        public VisibleAdsorber()
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
            _Agent.Distributor.Attach<IVisible>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IVisible>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IVisible GetGPI()
        {
            return _Visible;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IVisible gpi)
        {
            _Visible = gpi;
            _Visible.EquipEvent += _OnEquipEvent;
_Visible.StatusEvent += _OnStatusEvent;
_Visible.EnergyEvent += _OnEnergyEvent;
_Visible.TalkMessageEvent += _OnTalkMessageEvent;
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IVisible gpi)
        {
            EnableEvent.Invoke(false);
            _Visible.EquipEvent -= _OnEquipEvent;
_Visible.StatusEvent -= _OnStatusEvent;
_Visible.EnergyEvent -= _OnEnergyEvent;
_Visible.TalkMessageEvent -= _OnTalkMessageEvent;
            _Visible = null;
        }
        
        public void QueryStatus()
        {
            if(_Visible != null)
            {
                _Visible.QueryStatus();
            }
        }
        
        
        [System.Serializable]
        public class UnityEquipEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]> { }
        public UnityEquipEvent EquipEvent;
        
        
        private void _OnEquipEvent(Regulus.Project.ItIsNotAGame1.Data.EquipStatus[] arg0)
        {
            EquipEvent.Invoke(arg0);
        }
        

        [System.Serializable]
        public class UnityStatusEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus> { }
        public UnityStatusEvent StatusEvent;
        
        
        private void _OnStatusEvent(Regulus.Project.ItIsNotAGame1.Data.VisibleStatus arg0)
        {
            StatusEvent.Invoke(arg0);
        }
        

        [System.Serializable]
        public class UnityEnergyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Energy> { }
        public UnityEnergyEvent EnergyEvent;
        
        
        private void _OnEnergyEvent(Regulus.Project.ItIsNotAGame1.Data.Energy arg0)
        {
            EnergyEvent.Invoke(arg0);
        }
        

        [System.Serializable]
        public class UnityTalkMessageEvent : UnityEngine.Events.UnityEvent<System.String> { }
        public UnityTalkMessageEvent TalkMessageEvent;
        
        
        private void _OnTalkMessageEvent(System.String arg0)
        {
            TalkMessageEvent.Invoke(arg0);
        }
        
    }
}
                    