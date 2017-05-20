                    

namespace Regulus.Project.ItIsNotAGame1.Data.Adsorption
{
    using System.Linq;
        
    public class CastSkillAdsorber : UnityEngine.MonoBehaviour , Regulus.Remoting.Unity.Adsorber<ICastSkill>
    {
        private readonly Regulus.Utility.StageMachine _Machine;        
        
        public string Agent;

        private global::Regulus.Project.ItIsNotAGame.Data.Agent _Agent;

        [System.Serializable]
        public class UnityEnableEvent : UnityEngine.Events.UnityEvent<bool> {}
        public UnityEnableEvent EnableEvent;
        [System.Serializable]
        public class UnitySupplyEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ICastSkill> {}
        public UnitySupplyEvent SupplyEvent;
        Regulus.Project.ItIsNotAGame1.Data.ICastSkill _CastSkill;                        
       
        public CastSkillAdsorber()
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
            _Agent.Distributor.Attach<ICastSkill>(this);
        }

        private void _DispatchLeave()
        {
            _Agent.Distributor.Detach<ICastSkill>(this);
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

        public Regulus.Project.ItIsNotAGame1.Data.ICastSkill GetGPI()
        {
            return _CastSkill;
        }
        public void Supply(Regulus.Project.ItIsNotAGame1.Data.ICastSkill gpi)
        {
            _CastSkill = gpi;
            _CastSkill.HitNextsEvent += _OnHitNextsEvent;
            EnableEvent.Invoke(true);
            SupplyEvent.Invoke(gpi);
        }

        public void Unsupply(Regulus.Project.ItIsNotAGame1.Data.ICastSkill gpi)
        {
            EnableEvent.Invoke(false);
            _CastSkill.HitNextsEvent -= _OnHitNextsEvent;
            _CastSkill = null;
        }
        
        public void Cast(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE skill)
        {
            if(_CastSkill != null)
            {
                _CastSkill.Cast(skill);
            }
        }
        
        
        [System.Serializable]
        public class UnityHitNextsEvent : UnityEngine.Events.UnityEvent<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]> { }
        public UnityHitNextsEvent HitNextsEvent;
        
        
        private void _OnHitNextsEvent(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[] arg0)
        {
            HitNextsEvent.Invoke(arg0);
        }
        
    }
}
                    