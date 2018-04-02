   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CICastSkill : Regulus.Project.ItIsNotAGame1.Data.ICastSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CICastSkill(Guid id, bool have_return )
            {
                _HaveReturn = have_return ;
                _GhostIdName = id;            
            }
            

            Guid Regulus.Remoting.IGhost.GetID()
            {
                return _GhostIdName;
            }

            bool Regulus.Remoting.IGhost.IsReturnType()
            {
                return _HaveReturn;
            }
            object Regulus.Remoting.IGhost.GetInstance()
            {
                return this;
            }

            private event Regulus.Remoting.CallMethodCallback _CallMethodEvent;

            event Regulus.Remoting.CallMethodCallback Regulus.Remoting.IGhost.CallMethodEvent
            {
                add { this._CallMethodEvent += value; }
                remove { this._CallMethodEvent -= value; }
            }
            
            
                void Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Cast(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetMethod("Cast");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                


                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE _Id;
                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Id { get{ return _Id;} }

                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[] _Skills;
                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[] Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Skills { get{ return _Skills;} }

                System.Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]> _HitNextsEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]> Regulus.Project.ItIsNotAGame1.Data.ICastSkill.HitNextsEvent
                {
                    add { _HitNextsEvent += value;}
                    remove { _HitNextsEvent -= value;}
                }
                
            
        }
    }
