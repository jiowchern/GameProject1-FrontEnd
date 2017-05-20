                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class InventoryNotifierAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IInventoryNotifier>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier _InventoryNotifier;                        
       
        public InventoryNotifierAdsorber()
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
            _Agent.Distributor.Attach<IInventoryNotifier>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IInventoryNotifier>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier GetGPI()
        {
            return _InventoryNotifier;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier gpi)
        {
            _InventoryNotifier = gpi;
            _InventoryNotifier.AddEvent += _OnAddEvent;
_InventoryNotifier.RemoveEvent += _OnRemoveEvent;
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier gpi)
        {
            EnableEvent.Invoke(false);
            _InventoryNotifier.AddEvent -= _OnAddEvent;
_InventoryNotifier.RemoveEvent -= _OnRemoveEvent;
            _InventoryNotifier = null;
        }
        
        
        
        [System.Serializable]
        public class UnityAddEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Item> { }
        public UnityAddEvent AddEvent;
        
        
        private void _OnAddEvent(Regulus.Project.ItIsNotAGame1.Data.Item arg0)
        {
            AddEvent.Invoke(arg0);
        }
        

        [System.Serializable]
        public class UnityRemoveEvent : UnityEngine.Events.UnityEvent<System.Guid> { }
        public UnityRemoveEvent RemoveEvent;
        
        
        private void _OnRemoveEvent(System.Guid arg0)
        {
            RemoveEvent.Invoke(arg0);
        }
        
    }
}
                    