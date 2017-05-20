   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIPlayerProperys : Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIPlayerProperys(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIPlayerProperys" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIPlayerProperys" , this , value );
            }
            

                System.String _Realm;
                System.String Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys.Realm { get{ return _Realm;} }

                System.Guid _Id;
                System.Guid Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys.Id { get{ return _Id;} }

                System.Single _Strength;
                System.Single Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys.Strength { get{ return _Strength;} }

                System.Single _Health;
                System.Single Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys.Health { get{ return _Health;} }

            
        }
    }
