   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIDevelopActor : Regulus.Project.ItIsNotAGame1.Data.IDevelopActor , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIDevelopActor(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIDevelopActor" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIDevelopActor" , this , value );
            }
            
                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetBaseView(System.Single range)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="SetBaseView";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var rangeBytes = _Serializer.Serialize(range);  
    paramList.Add(rangeBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetSpeed(System.Single speed)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="SetSpeed";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var speedBytes = _Serializer.Serialize(speed);  
    paramList.Add(speedBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.MakeItem(System.String name,System.Single quality)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="MakeItem";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var nameBytes = _Serializer.Serialize(name);  
    paramList.Add(nameBytes);
 

    var qualityBytes = _Serializer.Serialize(quality);  
    paramList.Add(qualityBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.CreateItem(System.String name,System.Int32 count)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="CreateItem";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var nameBytes = _Serializer.Serialize(name);  
    paramList.Add(nameBytes);
 

    var countBytes = _Serializer.Serialize(count);  
    paramList.Add(countBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetPosition(System.Single x,System.Single y)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="SetPosition";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var xBytes = _Serializer.Serialize(x);  
    paramList.Add(xBytes);
 

    var yBytes = _Serializer.Serialize(y);  
    paramList.Add(yBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetRealm(System.String realm)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="SetRealm";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var realmBytes = _Serializer.Serialize(realm);  
    paramList.Add(realmBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }



            
        }
    }
