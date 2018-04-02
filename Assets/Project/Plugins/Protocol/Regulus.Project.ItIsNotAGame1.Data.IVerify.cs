   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIVerify : Regulus.Project.ItIsNotAGame1.Data.IVerify , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIVerify(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<System.Boolean> Regulus.Project.ItIsNotAGame1.Data.IVerify.Login(System.String _1,System.String _2)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<System.Boolean>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify).GetMethod("Login");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }
