                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class InventoryControllerAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IInventoryController>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IInventoryController> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IInventoryController _InventoryController;                        
       
        public InventoryControllerAdsorber()
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
            _Agent.Distributor.Attach<IInventoryController>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IInventoryController>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IInventoryController GetGPI()
        {
            return _InventoryController;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IInventoryController gpi)
        {
            _InventoryController = gpi;
            _InventoryController.BagItemsEvent += _OnBagItemsEvent;
_InventoryController.EquipItemsEvent += _OnEquipItemsEvent;
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IInventoryController gpi)
        {
            EnableEvent.Invoke(false);
            _InventoryController.BagItemsEvent -= _OnBagItemsEvent;
_InventoryController.EquipItemsEvent -= _OnEquipItemsEvent;
            _InventoryController = null;
        }
        
        public void Refresh()
        {
            if(_InventoryController != null)
            {
                _InventoryController.Refresh();
            }
        }

        public void Discard(System.Guid id)
        {
            if(_InventoryController != null)
            {
                _InventoryController.Discard(id);
            }
        }

        public void Equip(System.Guid id)
        {
            if(_InventoryController != null)
            {
                _InventoryController.Equip(id);
            }
        }

        public void Use(System.Guid id)
        {
            if(_InventoryController != null)
            {
                _InventoryController.Use(id);
            }
        }

        public void Unequip(System.Guid id)
        {
            if(_InventoryController != null)
            {
                _InventoryController.Unequip(id);
            }
        }
        
        
        [System.Serializable]
        public class UnityBagItemsEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Item[]> { }
        public UnityBagItemsEvent BagItemsEvent;
        
        
        private void _OnBagItemsEvent(Regulus.Project.ItIsNotAGame1.Data.Item[] arg0)
        {
            BagItemsEvent.Invoke(arg0);
        }
        

        [System.Serializable]
        public class UnityEquipItemsEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.Item[]> { }
        public UnityEquipItemsEvent EquipItemsEvent;
        
        
        private void _OnEquipItemsEvent(Regulus.Project.ItIsNotAGame1.Data.Item[] arg0)
        {
            EquipItemsEvent.Invoke(arg0);
        }
        
    }
}
                    