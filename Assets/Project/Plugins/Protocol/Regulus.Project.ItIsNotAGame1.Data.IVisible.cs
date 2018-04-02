   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIVisible : Regulus.Project.ItIsNotAGame1.Data.IVisible , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIVisible(Guid id, bool have_return )
            {
                _HaveReturn = have_return ;
                _GhostIdName = id;            
            }
            

            Guid Regulus.Remoting.IGhost.GetID()
            {
                return _GhostIdName;
            }

            bool Regulus.Remoting.IGhost.IsReturnType()
            {
                return _HaveReturn;
            }
            object Regulus.Remoting.IGhost.GetInstance()
            {
                return this;
            }

            private event Regulus.Remoting.CallMethodCallback _CallMethodEvent;

            event Regulus.Remoting.CallMethodCallback Regulus.Remoting.IGhost.CallMethodEvent
            {
                add { this._CallMethodEvent += value; }
                remove { this._CallMethodEvent -= value; }
            }
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IVisible.QueryStatus()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetMethod("QueryStatus");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
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
