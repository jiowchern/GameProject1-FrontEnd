   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountCreator : Regulus.Project.ItIsNotAGame1.Data.IAccountCreator , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIAccountCreator(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIAccountCreator" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIAccountCreator" , this , value );
            }
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountCreator.Create(Regulus.Project.ItIsNotAGame1.Data.Account account)
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



            
        }
    }
