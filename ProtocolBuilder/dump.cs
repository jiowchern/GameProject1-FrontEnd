   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountCreator : Regulus.Project.ItIsNotAGame1.Data.IAccountCreator , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountCreator(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountCreator.Create(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator).GetMethod("Create");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountFinder : Regulus.Project.ItIsNotAGame1.Data.IAccountFinder , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountFinder(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountByName(System.String _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountByName");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountById(System.Guid _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountById");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountManager : Regulus.Project.ItIsNotAGame1.Data.IAccountManager , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountManager(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Create(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Create");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.QueryAllAccount()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("QueryAllAccount");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Delete(System.String _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Delete");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Update(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Update");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIAccountStatus : Regulus.Project.ItIsNotAGame1.Data.IAccountStatus , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIAccountStatus(Guid id, bool have_return )
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
            
            


                System.Action _KickEvent;
                event System.Action Regulus.Project.ItIsNotAGame1.Data.IAccountStatus.KickEvent
                {
                    add { _KickEvent += value;}
                    remove { _KickEvent -= value;}
                }
                
            
        }
    }


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IAccountStatus 
    { 
        public class KickEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public KickEvent()
            {
                _Name = "KickEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure(soul_id , event_id , invoke_Event);                
                return new Action(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                
   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIBattleSkill : Regulus.Project.ItIsNotAGame1.Data.IBattleSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIBattleSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IBattleSkill.Disarm()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill).GetMethod("Disarm");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CICastSkill : Regulus.Project.ItIsNotAGame1.Data.ICastSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CICastSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.ICastSkill.Cast(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetMethod("Cast");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
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


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.ICastSkill 
    { 
        public class HitNextsEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public HitNextsEvent()
            {
                _Name = "HitNextsEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                
   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIDevelopActor : Regulus.Project.ItIsNotAGame1.Data.IDevelopActor , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIDevelopActor(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetBaseView(System.Single _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetBaseView");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetSpeed(System.Single _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetSpeed");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.MakeItem(System.String _1,System.Single _2)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("MakeItem");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.CreateItem(System.String _1,System.Int32 _2)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("CreateItem");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetPosition(System.Single _1,System.Single _2)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetPosition");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IDevelopActor.SetRealm(System.String _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetRealm");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIEmotion : Regulus.Project.ItIsNotAGame1.Data.IEmotion , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIEmotion(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IEmotion.Talk(System.String _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IEmotion).GetMethod("Talk");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIEquipmentNotifier : Regulus.Project.ItIsNotAGame1.Data.IEquipmentNotifier , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIEquipmentNotifier(Guid id, bool have_return )
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

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIInventoryController : Regulus.Project.ItIsNotAGame1.Data.IInventoryController , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIInventoryController(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Refresh()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Refresh");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Discard(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Discard");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Equip(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Equip");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Use(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Use");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IInventoryController.Unequip(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Unequip");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
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


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController 
    { 
        public class BagItemsEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public BagItemsEvent()
            {
                _Name = "BagItemsEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.Item[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.Item[]>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController 
    { 
        public class EquipItemsEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public EquipItemsEvent()
            {
                _Name = "EquipItemsEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.Item[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.Item[]>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                
   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIInventoryNotifier : Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIInventoryNotifier(Guid id, bool have_return )
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


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier 
    { 
        public class AddEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public AddEvent()
            {
                _Name = "AddEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.Item>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.Item>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier 
    { 
        public class RemoveEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public RemoveEvent()
            {
                _Name = "RemoveEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<System.Guid>(soul_id , event_id , invoke_Event);                
                return new Action<System.Guid>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                
   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIJumpMap : Regulus.Project.ItIsNotAGame1.Data.IJumpMap , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIJumpMap(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IJumpMap.Ready()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap).GetMethod("Ready");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                


                System.String _Realm;
                System.String Regulus.Project.ItIsNotAGame1.Data.IJumpMap.Realm { get{ return _Realm;} }

            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIMakeSkill : Regulus.Project.ItIsNotAGame1.Data.IMakeSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIMakeSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.Create(System.String _1,System.Int32[] _2)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("Create");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.Exit()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("Exit");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.QueryFormula()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("QueryFormula");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



                System.Action<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]> _FormulasEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]> Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.FormulasEvent
                {
                    add { _FormulasEvent += value;}
                    remove { _FormulasEvent -= value;}
                }
                
            
        }
    }


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IMakeSkill 
    { 
        public class FormulasEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public FormulasEvent()
            {
                _Name = "FormulasEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                
   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIMoveController : Regulus.Project.ItIsNotAGame1.Data.IMoveController , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIMoveController(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.RunForward()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("RunForward");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.Forward()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("Forward");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.Backward()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("Backward");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.StopMove()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("StopMove");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.TrunLeft()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("TrunLeft");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.TrunRight()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("TrunRight");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IMoveController.StopTrun()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("StopTrun");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIBagNotifier : Regulus.Project.ItIsNotAGame1.Data.IBagNotifier , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIBagNotifier(Guid id, bool have_return )
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

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIPlayerProperys : Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIPlayerProperys(Guid id, bool have_return )
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

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIGameRecorder : Regulus.Project.ItIsNotAGame1.Data.IGameRecorder , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIGameRecorder(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord> Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Load(System.Guid _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Load");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Save(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Save");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIQuitable : Regulus.Project.ItIsNotAGame1.Data.IQuitable , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIQuitable(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.IQuitable.Quit()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IQuitable).GetMethod("Quit");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CINormalSkill : Regulus.Project.ItIsNotAGame1.Data.INormalSkill , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CINormalSkill(Guid id, bool have_return )
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
            
            
                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Explore(System.Guid _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Explore");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Battle()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Battle");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.INormalSkill.Make()
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Make");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIStorage : Regulus.Project.ItIsNotAGame1.Data.IStorage , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIStorage(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountByName(System.String _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountByName");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account> Regulus.Project.ItIsNotAGame1.Data.IAccountFinder.FindAccountById(System.Guid _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountById");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                




                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Create(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Create");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.QueryAllAccount()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account[]>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("QueryAllAccount");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Delete(System.String _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Delete");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT> Regulus.Project.ItIsNotAGame1.Data.IAccountManager.Update(Regulus.Project.ItIsNotAGame1.Data.Account _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Update");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                




                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord> Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Load(System.Guid _1)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Load");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    return returnValue;
                }

                
 

                void Regulus.Project.ItIsNotAGame1.Data.IGameRecorder.Save(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord _1)
                {                    

                    Regulus.Remoting.IValue returnValue = null;
                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Save");
                    _CallMethodEvent(info , new object[] {_1} , returnValue);                    
                    
                }

                






            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIStorageCompetences : Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIStorageCompetences(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.Query()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("Query");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                
 

                Regulus.Remoting.Value<System.Guid> Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences.QueryForId()
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<System.Guid>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("QueryForId");
                    _CallMethodEvent(info , new object[] {} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIVerify : Regulus.Project.ItIsNotAGame1.Data.IVerify , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIVerify(Guid id, bool have_return )
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
            
            
                Regulus.Remoting.Value<System.Boolean> Regulus.Project.ItIsNotAGame1.Data.IVerify.Login(System.String _1,System.String _2)
                {                    

                    
    var returnValue = new Regulus.Remoting.Value<System.Boolean>();
    

                    var info = typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify).GetMethod("Login");
                    _CallMethodEvent(info , new object[] {_1 ,_2} , returnValue);                    
                    return returnValue;
                }

                



            
        }
    }

   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIVersion : Regulus.Project.ItIsNotAGame1.Data.IVersion , Regulus.Remoting.IGhost
        {
            readonly bool _HaveReturn ;
            
            readonly Guid _GhostIdName;
            
            
            
            public CIVersion(Guid id, bool have_return )
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
            
            

                System.String _Number;
                System.String Regulus.Project.ItIsNotAGame1.Data.IVersion.Number { get{ return _Number;} }

            
        }
    }

   
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


    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class EquipEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public EquipEvent()
            {
                _Name = "EquipEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class StatusEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public StatusEvent()
            {
                _Name = "StatusEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.VisibleStatus>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class EnergyEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public EnergyEvent()
            {
                _Name = "EnergyEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<Regulus.Project.ItIsNotAGame1.Data.Energy>(soul_id , event_id , invoke_Event);                
                return new Action<Regulus.Project.ItIsNotAGame1.Data.Energy>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

    using System;  
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Event.IVisible 
    { 
        public class TalkMessageEvent : Regulus.Remoting.IEventProxyCreator
        {

            Type _Type;
            string _Name;
            
            public TalkMessageEvent()
            {
                _Name = "TalkMessageEvent";
                _Type = typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible);                   
            
            }
            Delegate Regulus.Remoting.IEventProxyCreator.Create(Guid soul_id,int event_id, Regulus.Remoting.InvokeEventCallabck invoke_Event)
            {                
                var closure = new Regulus.Remoting.GenericEventClosure<System.String>(soul_id , event_id , invoke_Event);                
                return new Action<System.String>(closure.Run);
            }
        

            Type Regulus.Remoting.IEventProxyCreator.GetType()
            {
                return _Type;
            }            

            string Regulus.Remoting.IEventProxyCreator.GetName()
            {
                return _Name;
            }            
        }
    }
                

            using System;  
            using System.Collections.Generic;
            
            namespace Regulus.Project.ItIsNotAGame.Data{ 
                public class Protocol : Regulus.Remoting.IProtocol
                {
                    Regulus.Remoting.InterfaceProvider _InterfaceProvider;
                    Regulus.Remoting.EventProvider _EventProvider;
                    Regulus.Remoting.MemberMap _MemberMap;
                    Regulus.Serialization.ISerializer _Serializer;
                    public Protocol()
                    {
                        var types = new Dictionary<Type, Type>();
                        types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountCreator) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountFinder) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountManager) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountStatus) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIBattleSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CICastSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIDevelopActor) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IEmotion) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIEmotion) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IEquipmentNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIEquipmentNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIInventoryController) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIInventoryNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIJumpMap) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIMakeSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIMoveController) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IBagNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIBagNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIPlayerProperys) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIGameRecorder) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IQuitable) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIQuitable) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CINormalSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IStorage) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIStorage) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIStorageCompetences) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVerify) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVersion) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVersion) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVisible) );
                        _InterfaceProvider = new Regulus.Remoting.InterfaceProvider(types);

                        var eventClosures = new List<Regulus.Remoting.IEventProxyCreator>();
                        eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IAccountStatus.KickEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.ICastSkill.HitNextsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController.BagItemsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController.EquipItemsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier.AddEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier.RemoveEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IMakeSkill.FormulasEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.EquipEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.StatusEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.EnergyEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.TalkMessageEvent() );
                        _EventProvider = new Regulus.Remoting.EventProvider(eventClosures);

                        _Serializer = new Regulus.Serialization.Serializer(new Regulus.Serialization.DescriberBuilder(typeof(AForge.Math.Geometry.GrahamConvexHull),typeof(Regulus.CustomType.Point),typeof(Regulus.CustomType.Polygon),typeof(Regulus.CustomType.Vector2),typeof(Regulus.CustomType.Vector2[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Account),typeof(Regulus.Project.ItIsNotAGame1.Data.Account[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT),typeof(Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE),typeof(Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ChestLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ChestLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Determination),typeof(Regulus.Project.ItIsNotAGame1.Data.Effect),typeof(Regulus.Project.ItIsNotAGame1.Data.Effect[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EFFECT_TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.Energy),typeof(Regulus.Project.ItIsNotAGame1.Data.Energy.TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.EnteranceLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EnteranceLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ENTITY),typeof(Regulus.Project.ItIsNotAGame1.Data.ENTITY[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityData),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityData[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityGroupLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityGroupLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EQUIP_PART),typeof(Regulus.Project.ItIsNotAGame1.Data.EquipStatus),typeof(Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]),typeof(Regulus.Project.ItIsNotAGame1.Data.FieldLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.FieldLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord),typeof(Regulus.Project.ItIsNotAGame1.Data.Item),typeof(Regulus.Project.ItIsNotAGame1.Data.Item[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ITEM_FEATURES),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemEffect),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemEffect[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormula),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormula[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeed),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeed[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeedLite),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeedLite[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemPrototype),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemPrototype[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Location),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeUnitInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeUnitInfomation[]),typeof(Regulus.Project.ItIsNotAGame1.Data.PortalData),typeof(Regulus.Project.ItIsNotAGame1.Data.ProtalLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ProtalLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.RealmInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.Resource),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceItem),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceItem[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.SkillData),typeof(Regulus.Project.ItIsNotAGame1.Data.SkillData[]),typeof(Regulus.Project.ItIsNotAGame1.Data.StaticLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.StaticLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.StrongholdLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.StrongholdLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.TownInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.Translate),typeof(Regulus.Project.ItIsNotAGame1.Data.Translate[]),typeof(Regulus.Project.ItIsNotAGame1.Data.VisibleStatus),typeof(Regulus.Project.ItIsNotAGame1.Data.WallData),typeof(Regulus.Project.ItIsNotAGame1.Data.WallLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.WallLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Game.Data.LEVEL_UNIT),typeof(Regulus.Remoting.ClientToServerOpCode),typeof(Regulus.Remoting.PackageCallMethod),typeof(Regulus.Remoting.PackageErrorMethod),typeof(Regulus.Remoting.PackageInvokeEvent),typeof(Regulus.Remoting.PackageLoadSoul),typeof(Regulus.Remoting.PackageLoadSoulCompile),typeof(Regulus.Remoting.PackageProtocolSubmit),typeof(Regulus.Remoting.PackageRelease),typeof(Regulus.Remoting.PackageReturnValue),typeof(Regulus.Remoting.PackageUnloadSoul),typeof(Regulus.Remoting.PackageUpdateProperty),typeof(Regulus.Remoting.RequestPackage),typeof(Regulus.Remoting.ResponsePackage),typeof(Regulus.Remoting.ServerToClientOpCode),typeof(System.Boolean),typeof(System.Byte[]),typeof(System.Byte[][]),typeof(System.Char),typeof(System.Char[]),typeof(System.Double),typeof(System.Guid),typeof(System.Int32),typeof(System.Int32[]),typeof(System.Single),typeof(System.String)));


                        _MemberMap = new Regulus.Remoting.MemberMap(new[] {typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator).GetMethod("Create"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountByName"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder).GetMethod("FindAccountById"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Create"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("QueryAllAccount"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Delete"),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager).GetMethod("Update"),typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill).GetMethod("Disarm"),typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetMethod("Cast"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetBaseView"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetSpeed"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("MakeItem"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("CreateItem"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetPosition"),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor).GetMethod("SetRealm"),typeof(Regulus.Project.ItIsNotAGame1.Data.IEmotion).GetMethod("Talk"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Refresh"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Discard"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Equip"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Use"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetMethod("Unequip"),typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap).GetMethod("Ready"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("Create"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("Exit"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetMethod("QueryFormula"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("RunForward"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("Forward"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("Backward"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("StopMove"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("TrunLeft"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("TrunRight"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController).GetMethod("StopTrun"),typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Load"),typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder).GetMethod("Save"),typeof(Regulus.Project.ItIsNotAGame1.Data.IQuitable).GetMethod("Quit"),typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Explore"),typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Battle"),typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill).GetMethod("Make"),typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("Query"),typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences).GetMethod("QueryForId"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify).GetMethod("Login"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetMethod("QueryStatus")} ,new[]{ typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus).GetEvent("KickEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetEvent("HitNextsEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetEvent("BagItemsEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController).GetEvent("EquipItemsEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier).GetEvent("AddEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier).GetEvent("RemoveEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill).GetEvent("FormulasEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetEvent("EquipEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetEvent("StatusEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetEvent("EnergyEvent"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetEvent("TalkMessageEvent") }, new [] {typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetProperty("Id"),typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill).GetProperty("Skills"),typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap).GetProperty("Realm"),typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys).GetProperty("Realm"),typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys).GetProperty("Id"),typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys).GetProperty("Strength"),typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys).GetProperty("Health"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVersion).GetProperty("Number"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("EntityType"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("Id"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("Name"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("View"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("Direction"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("Status"),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible).GetProperty("Position") }, new [] {typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager),typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus),typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill),typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill),typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor),typeof(Regulus.Project.ItIsNotAGame1.Data.IEmotion),typeof(Regulus.Project.ItIsNotAGame1.Data.IEquipmentNotifier),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController),typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier),typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap),typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill),typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController),typeof(Regulus.Project.ItIsNotAGame1.Data.IBagNotifier),typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys),typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder),typeof(Regulus.Project.ItIsNotAGame1.Data.IQuitable),typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill),typeof(Regulus.Project.ItIsNotAGame1.Data.IStorage),typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences),typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify),typeof(Regulus.Project.ItIsNotAGame1.Data.IVersion),typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible)});
                    }

                    byte[] Regulus.Remoting.IProtocol.VerificationCode { get { return new byte[]{74,200,111,90,178,187,148,77,12,21,234,64,185,54,37,222};} }
                    Regulus.Remoting.InterfaceProvider Regulus.Remoting.IProtocol.GetInterfaceProvider()
                    {
                        return _InterfaceProvider;
                    }

                    Regulus.Remoting.EventProvider Regulus.Remoting.IProtocol.GetEventProvider()
                    {
                        return _EventProvider;
                    }

                    Regulus.Serialization.ISerializer Regulus.Remoting.IProtocol.GetSerialize()
                    {
                        return _Serializer;
                    }

                    Regulus.Remoting.MemberMap Regulus.Remoting.IProtocol.GetMemberMap()
                    {
                        return _MemberMap;
                    }
                    
                }
            }
            
