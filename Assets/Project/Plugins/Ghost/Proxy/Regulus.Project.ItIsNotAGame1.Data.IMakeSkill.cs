   
    using System;  
    
    using System.Collections.Generic;
    
    namespace Regulus.Project.ItIsNotAGame1.Data.Ghost 
    { 
        public class CIMakeSkill : Regulus.Project.ItIsNotAGame1.Data.IMakeSkill , Regulus.Remoting.IGhost
        {
            bool _HaveReturn ;
            Regulus.Remoting.IGhostRequest _Requester;
            Guid _GhostIdName;
            Regulus.Remoting.ReturnValueQueue _Queue;
            readonly Regulus.Serialization.ISerializer _Serializer ;
            public CIMakeSkill(Regulus.Remoting.IGhostRequest requester , Guid id,Regulus.Remoting.ReturnValueQueue queue, bool have_return , Regulus.Serialization.ISerializer serializer)
            {
                _Serializer = serializer;

                _Requester = requester;
                _HaveReturn = have_return ;
                _GhostIdName = id;
                _Queue = queue;
            }

            void Regulus.Remoting.IGhost.OnEvent(string name_event, byte[][] args)
            {
                Regulus.Remoting.AgentCore.CallEvent(name_event , "CIMakeSkill" , this , args, _Serializer);
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
                Regulus.Remoting.AgentCore.UpdateProperty(name , "CIMakeSkill" , this , value );
            }
            
                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.Create(System.String formula,System.Int32[] amounts)
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Create";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

    var formulaBytes = _Serializer.Serialize(formula);  
    paramList.Add(formulaBytes);
 

    var amountsBytes = _Serializer.Serialize(amounts);  
    paramList.Add(amountsBytes);

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.Exit()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="Exit";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }
 

                void Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.QueryFormula()
                {                    

                        
                    var packageCallMethod = new Regulus.Remoting.PackageCallMethod();
                    packageCallMethod.EntityId = _GhostIdName;
                    packageCallMethod.MethodName ="QueryFormula";
                    
                    var paramList = new System.Collections.Generic.List<byte[]>();

packageCallMethod.MethodParams = paramList.ToArray();
                    _Requester.Request(Regulus.Remoting.ClientToServerOpCode.CallMethod , packageCallMethod.ToBuffer(_Serializer));

                    
                }



                System.Action<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]> _FormulasEvent;
                event System.Action<Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]> Regulus.Project.ItIsNotAGame1.Data.IMakeSkill.FormulasEvent
                {
                    add { _FormulasEvent += value;}
                    remove { _FormulasEvent -= value;}
                }
                
            
        }
    }
