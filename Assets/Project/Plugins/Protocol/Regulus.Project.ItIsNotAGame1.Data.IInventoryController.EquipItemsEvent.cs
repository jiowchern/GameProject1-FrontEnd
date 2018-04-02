
    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController 
    { 
        public class EquipItemsEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public EquipItemsEvent()
            {
                _Name = "EquipItemsEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.Item[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.Item[]>(closure.Run);
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
                