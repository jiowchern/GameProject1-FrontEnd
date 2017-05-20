
    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IAccountStatus 
    { 
        public class KickEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public KickEvent()
            {
                _Name = "KickEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id, Action<Guid, string, object[]> invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure(soul_id , _Name , invoke_Event);                
                return new Action(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                