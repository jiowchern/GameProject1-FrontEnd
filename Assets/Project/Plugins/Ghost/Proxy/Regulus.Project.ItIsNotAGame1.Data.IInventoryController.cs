   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIInventoryController : Regulus.Project.ItIsNotAGame1.Data.IInventoryController , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIInventoryController(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIInventoryController" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIInventoryController" , this , value );
            }
            
                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Refresh()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Refresh";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Discard(System.Guid id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Discard";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var idBytes = _Serializer.Serialize(id);  
    paramList.Add(idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Equip(System.Guid id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Equip";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var idBytes = _Serializer.Serialize(id);  
    paramList.Add(idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Use(System.Guid id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Use";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var idBytes = _Serializer.Serialize(id);  
    paramList.Add(idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Unequip(System.Guid id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Unequip";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var idBytes = _Serializer.Serialize(id);  
    paramList.Add(idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }



                System.Action<Regulus.Project.ItIsNotAGame1.Data.Item[]> _BagItemsEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.Item[]> Regulus.Project.ItIsNotAGame1.Data.IInventoryController.BagItemsEvent
                {
                    add { _BagItemsEvent += value;}
                    remove { _BagItemsEvent -= value;}
                }
                

                System.Action<Regulus.Project.ItIsNotAGame1.Data.Item[]> _EquipItemsEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.Item[]> Regulus.Project.ItIsNotAGame1.Data.IInventoryController.EquipItemsEvent
                {
                    add { _EquipItemsEvent += value;}
                    remove { _EquipItemsEvent -= value;}
                }
                
            
        }
    }
