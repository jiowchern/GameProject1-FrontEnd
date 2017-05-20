                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class DevelopActorAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IDevelopActor>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IDevelopActor> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IDevelopActor _DevelopActor;                        
       
        public DevelopActorAdsorber()
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
            _Agent.Distributor.Attach<IDevelopActor>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IDevelopActor>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IDevelopActor GetGPI()
        {
            return _DevelopActor;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor gpi)
        {
            _DevelopActor = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor gpi)
        {
            EnableEvent.Invoke(false);
            
            _DevelopActor = null;
        }
        
        public void SetBaseView(System.Single range)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.SetBaseView(range);
            }
        }

        public void SetSpeed(System.Single speed)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.SetSpeed(speed);
            }
        }

        public void MakeItem(System.String name,System.Single quality)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.MakeItem(name,quality);
            }
        }

        public void CreateItem(System.String name,System.Int32 count)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.CreateItem(name,count);
            }
        }

        public void SetPosition(System.Single x,System.Single y)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.SetPosition(x,y);
            }
        }

        public void SetRealm(System.String realm)
        {
            if(_DevelopActor != null)
            {
                _DevelopActor.SetRealm(realm);
            }
        }
        
        
    }
}
                    