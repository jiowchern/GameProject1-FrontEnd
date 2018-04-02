   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIStorageCompetences : Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIStorageCompetences(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.Query()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("Query");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<System.Guid> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.QueryForId()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<System.Guid>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("QueryForId");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }
