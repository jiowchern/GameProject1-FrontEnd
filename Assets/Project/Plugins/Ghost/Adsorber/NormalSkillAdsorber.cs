                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class NormalSkillAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<INormalSkill>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.INormalSkill> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.INormalSkill _NormalSkill;                        
       
        public NormalSkillAdsorber()
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
            _Agent.Distributor.Attach<INormalSkill>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<INormalSkill>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.INormalSkill GetGPI()
        {
            return _NormalSkill;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.INormalSkill gpi)
        {
            _NormalSkill = gpi;
            
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.INormalSkill gpi)
        {
            EnableEvent.Invoke(false);
            
            _NormalSkill = null;
        }
        
        public void Explore(System.Guid target)
        {
            if(_NormalSkill != null)
            {
                _NormalSkill.Explore(target);
            }
        }

        public void Battle()
        {
            if(_NormalSkill != null)
            {
                _NormalSkill.Battle();
            }
        }

        public void Make()
        {
            if(_NormalSkill != null)
            {
                _NormalSkill.Make();
            }
        }
        
        
    }
}
                    