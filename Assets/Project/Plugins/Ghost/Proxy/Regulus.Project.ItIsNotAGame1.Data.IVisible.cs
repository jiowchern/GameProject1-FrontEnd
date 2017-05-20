   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIVisible : Regulus.Project.ItIsNotAGame1.Data.IVisible , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIVisible(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIVisible" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIVisible" , this , value );
            }
            
                void Regulus.Project.ItIsNotAGame1.Data.IVisible.QueryStatus()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="QueryStatus";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }


                Regulus.Project.ItIsNotAGame1.Data.ENTITY _EntityType;
                Regulus.Project.ItIsNotAGame1.Data.ENTITY Regulus.Project.ItIsNotAGame1.Data.IVisible.EntityType { get{ return _EntityType;} }

                System.Guid _Id;
                System.Guid Regulus.Project.ItIsNotAGame1.Data.IVisible.Id { get{ return _Id;} }

                System.String _Name;
                System.String Regulus.Project.ItIsNotAGame1.Data.IVisible.Name { get{ return _Name;} }

                System.Single _View;
                System.Single Regulus.Project.ItIsNotAGame1.Data.IVisible.View { get{ return _View;} }

                System.Single _Direction;
                System.Single Regulus.Project.ItIsNotAGame1.Data.IVisible.Direction { get{ return _Direction;} }

                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE _Status;
                Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE Regulus.Project.ItIsNotAGame1.Data.IVisible.Status { get{ return _Status;} }

                Regulus.CustomType.Vector2 _Position;
                Regulus.CustomType.Vector2 Regulus.Project.ItIsNotAGame1.Data.IVisible.Position { get{ return _Position;} }

                System.Action<Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]> _EquipEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]> Regulus.Project.ItIsNotAGame1.Data.IVisible.EquipEvent
                {
                    add { _EquipEvent += value;}
                    remove { _EquipEvent -= value;}
                }
                

                System.Action<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus> _StatusEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus> Regulus.Project.ItIsNotAGame1.Data.IVisible.StatusEvent
                {
                    add { _StatusEvent += value;}
                    remove { _StatusEvent -= value;}
                }
                

                System.Action<Regulus.Project.ItIsNotAGame1.Data.Energy> _EnergyEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.Energy> Regulus.Project.ItIsNotAGame1.Data.IVisible.EnergyEvent
                {
                    add { _EnergyEvent += value;}
                    remove { _EnergyEvent -= value;}
                }
                

                System.Action<System.String> _TalkMessageEvent;
                event System.Action<System.String> Regulus.Project.ItIsNotAGame1.Data.IVisible.TalkMessageEvent
                {
                    add { _TalkMessageEvent += value;}
                    remove { _TalkMessageEvent -= value;}
                }
                
            
        }
    }
