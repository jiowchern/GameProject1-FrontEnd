   
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
