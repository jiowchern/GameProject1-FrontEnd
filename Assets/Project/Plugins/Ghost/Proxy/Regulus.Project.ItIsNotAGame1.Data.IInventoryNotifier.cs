   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIInventoryNotifier : Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIInventoryNotifier(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIInventoryNotifier" , this , args, _Serializer);
            }

            Guid Regulus.Remoting.IGhost.GetID()
            {
                return _GhostIdName;
            }

            bool Regulus.Remoting.IGhost.IsReturnType()
            {
                return _HaveReturn;
            }

            void Regulus.Remoting.IGhost.OnProperty(string name, object value)
            {
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIInventoryNotifier" , this , value );
            }
            


                System.Action<Regulus.Project.ItIsNotAGame1.Data.Item> _AddEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.Item> Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier.AddEvent
                {
                    add { _AddEvent += value;}
                    remove { _AddEvent -= value;}
                }
                

                System.Action<System.Guid> _RemoveEvent;
                event System.Action<System.Guid> Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier.RemoveEvent
                {
                    add { _RemoveEvent += value;}
                    remove { _RemoveEvent -= value;}
                }
                
            
        }
    }
