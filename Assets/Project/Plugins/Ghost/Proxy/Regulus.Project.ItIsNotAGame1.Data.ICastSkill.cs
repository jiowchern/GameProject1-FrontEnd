   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CICastSkill : Regulus.Project.ItIsNotAGame1.Data.ICastSkill , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CICastSkill(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CICastSkill" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CICastSkill" , this , value );
            }
            
                void Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Cast(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE skill)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Cast";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var skillBytes = _Serializer.Serialize(skill);  
    paramList.Add(skillBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }


                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE _Id;
                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Id { get{ return _Id;} }

                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[] _Skills;
                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[] Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Skills { get{ return _Skills;} }

                System.Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]> _HitNextsEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]> Regulus.Project.ItIsNotAGame1.Data.ICastSkill.HitNextsEvent
                {
                    add { _HitNextsEvent += value;}
                    remove { _HitNextsEvent -= value;}
                }
                
            
        }
    }
