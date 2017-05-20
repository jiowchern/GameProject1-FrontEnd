                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class MakeSkillAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<IMakeSkill>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.IMakeSkill> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.IMakeSkill _MakeSkill;                        
       
        public MakeSkillAdsorber()
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
            _Agent.Distributor.Attach<IMakeSkill>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<IMakeSkill>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.IMakeSkill GetGPI()
        {
            return _MakeSkill;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill gpi)
        {
            _MakeSkill = gpi;
            _MakeSkill.FormulasEvent += _OnFormulasEvent;
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill gpi)
        {
            EnableEvent.Invoke(false);
            _MakeSkill.FormulasEvent -= _OnFormulasEvent;
            _MakeSkill = null;
        }
        
        public void Create(System.String formula,System.Int32[] amounts)
        {
            if(_MakeSkill != null)
            {
                _MakeSkill.Create(formula,amounts);
            }
        }

        public void Exit()
        {
            if(_MakeSkill != null)
            {
                _MakeSkill.Exit();
            }
        }

        public void QueryFormula()
        {
            if(_MakeSkill != null)
            {
                _MakeSkill.QueryFormula();
            }
        }
        
        
        [System.Serializable]
        public class UnityFormulasEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]> { }
        public UnityFormulasEvent FormulasEvent;
        
        
        private void _OnFormulasEvent(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[] arg0)
        {
            FormulasEvent.Invoke(arg0);
        }
        
    }
}
                    