   
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
