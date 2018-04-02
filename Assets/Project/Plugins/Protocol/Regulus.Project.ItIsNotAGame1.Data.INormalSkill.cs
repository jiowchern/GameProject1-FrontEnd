   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CINormalSkill : Regulus.Project.ItIsNotAGame1.Data.INormalSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CINormalSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Explore(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Explore");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Battle()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Battle");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Make()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Make");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }
