   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountFinder : Regulus.Project.ItIsNotAGame1.Data.IAccountFinder , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountFinder(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountByName(System.String _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountByName");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountById(System.Guid _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountById");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }
