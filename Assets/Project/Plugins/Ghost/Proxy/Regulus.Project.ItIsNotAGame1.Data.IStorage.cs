   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIStorage : Regulus.Project.ItIsNotAGame1.Data.IStorage , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIStorage(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIStorage" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIStorage" , this , value );
            }
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountByName(System.String id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="FindAccountByName";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var idBytes = _Serializer.Serialize(id);  
    paramList.Add(idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountById(System.Guid accountId)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="FindAccountById";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var accountIdBytes = _Serializer.Serialize(accountId);  
    paramList.Add(accountIdBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }




                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Create(Regulus.Project.ItIsNotAGame1.Data.Account account)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Create";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var accountBytes = _Serializer.Serialize(account);  
    paramList.Add(accountBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.QueryAllAccount()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="QueryAllAccount";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Delete(System.String account)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Delete";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var accountBytes = _Serializer.Serialize(account);  
    paramList.Add(accountBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Update(Regulus.Project.ItIsNotAGame1.Data.Account account)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Update";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var accountBytes = _Serializer.Serialize(account);  
    paramList.Add(accountBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }




                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord> Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Load(System.Guid account_id)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Load";
                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord>();
    var returnId = _Queue.PushReturnValue(returnValue);    
    packageCallMethod.ReturnId = returnId;

                    var paramList = new System.Collections.Generic.List<byte[]>();

    var account_idBytes = _Serializer.Serialize(account_id);  
    paramList.Add(account_idBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    return returnValue;
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Save(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord game_player_record)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Save";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var game_player_recordBytes = _Serializer.Serialize(game_player_record);  
    paramList.Add(game_player_recordBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }






            
        }
    }
