
    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class TalkMessageEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public TalkMessageEvent()
            {
                _Name = "TalkMessageEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<System.String>(soul_id , event_id , invoke_Event);                
                return new Action<System.String>(closure.Run);
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
                