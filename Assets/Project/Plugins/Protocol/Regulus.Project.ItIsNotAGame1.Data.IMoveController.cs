   
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
