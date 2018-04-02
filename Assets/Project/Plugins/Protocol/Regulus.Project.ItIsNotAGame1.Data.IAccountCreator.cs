   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountCreator : Regulus.Project.ItIsNotAGame1.Data.IAccountCreator , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountCreator(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountCreator.Create(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator).GetMethod("Create");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }
