   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIBattleSkill : Regulus.Project.ItIsNotAGame1.Data.IBattleSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIBattleSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IBattleSkill.Disarm()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill).GetMethod("Disarm");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }
