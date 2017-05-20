
    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.ICastSkill 
    { 
        public class HitNextsEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public HitNextsEvent()
            {
                _Name = "HitNextsEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id, Action<Guid, string, object[]> invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]>(soul_id , _Name , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]>(closure.Run);
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
                