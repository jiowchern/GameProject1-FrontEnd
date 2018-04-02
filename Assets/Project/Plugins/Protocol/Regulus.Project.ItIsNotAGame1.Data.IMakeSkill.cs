   
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
