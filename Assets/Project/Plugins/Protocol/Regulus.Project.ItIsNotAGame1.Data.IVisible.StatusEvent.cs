
    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class StatusEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public StatusEvent()
            {
                _Name = "StatusEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus>(closure.Run);
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
                