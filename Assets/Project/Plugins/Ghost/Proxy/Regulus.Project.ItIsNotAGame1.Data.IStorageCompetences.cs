   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIStorageCompetences : Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIStorageCompetences(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIStorageCompetences" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIStorageCompetences" , this , value );
            }
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.Query()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Query";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                Regulus.Remoting.Value<System.Guid> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.QueryForId()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="QueryForId";
                    
    var returnValue = new Regulus.Remoting.Value<System.Guid>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }



            
        }
    }
