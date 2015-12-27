//uScript Generated Code - Build 0.9.2255
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class active_anim : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_11_System_String = "close";
   System.String local_15_System_String = "open";
   System.Single local_16_System_Single = (float) 0;
   System.Single local_17_System_Single = (float) 0;
   System.String local_2_System_String = "open";
   System.Single local_20_System_Single = (float) 0;
   System.Single local_22_System_Single = (float) 0;
   System.String local_3_System_String = "close";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_18 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_4 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_4 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_4;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_4;
   System.Single logic_uScriptAct_GetAnimationState_animLength_4;
   System.Single logic_uScriptAct_GetAnimationState_speed_4;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_4;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_4;
   bool logic_uScriptAct_GetAnimationState_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_5 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_5 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_5 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_5 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_5 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_7 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_7 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = (float) 0;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_9 = null;
   System.String logic_uScriptAct_SetAnimationPosition_animationName_9 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_9 = (float) 0;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_10 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_10 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_10 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_12 = null;
   System.String logic_uScriptAct_GetAnimationState_animationName_12 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_12;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_12;
   System.Single logic_uScriptAct_GetAnimationState_animLength_12;
   System.Single logic_uScriptAct_GetAnimationState_speed_12;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_12;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_12;
   bool logic_uScriptAct_GetAnimationState_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_13 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_13 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_13 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_13 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_14 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_14 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_14 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_14 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_14 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_19 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_19 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_19;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_19;
   bool logic_uScriptAct_SubtractFloat_Out_19 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_21 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_21 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_21 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_21;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_21;
   bool logic_uScriptAct_SubtractFloat_Out_21 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_TimesToTrigger_1 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = null;
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_0 || false == m_RegisteredForEvents )
      {
         owner_Connection_0 = parentGameObject;
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      if ( null == owner_Connection_18 || false == m_RegisteredForEvents )
      {
         owner_Connection_18 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.TimesToTrigger = event_UnityEngine_GameObject_TimesToTrigger_1;
               }
            }
            {
               uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Triggers>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_0 )
      {
         {
            uScript_Triggers component = owner_Connection_0.GetComponent<uScript_Triggers>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_21.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Finished += uScriptAct_PlayAnimation_Finished_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out += uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.Out += uScriptAct_SetAnimationPosition_Out_9;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Finished += uScriptAct_PlayAnimation_Finished_14;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.Finished -= uScriptAct_PlayAnimation_Finished_5;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.Out -= uScriptAct_SetAnimationPosition_Out_7;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.Out -= uScriptAct_SetAnimationPosition_Out_9;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.Finished -= uScriptAct_PlayAnimation_Finished_14;
   }
   
   void Instance_OnEnterTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Triggers.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void uScriptAct_PlayAnimation_Finished_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_5( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_7( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_9( );
   }
   
   void uScriptAct_PlayAnimation_Finished_14(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_14( );
   }
   
   void Relay_OnEnterTrigger_1()
   {
      Relay_In_6();
   }
   
   void Relay_OnExitTrigger_1()
   {
      Relay_In_8();
   }
   
   void Relay_WhileInsideTrigger_1()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_4 = owner_Connection_18;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_4 = local_3_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.In(logic_uScriptAct_GetAnimationState_target_4, logic_uScriptAct_GetAnimationState_animationName_4, out logic_uScriptAct_GetAnimationState_weight_4, out logic_uScriptAct_GetAnimationState_normalizedPosition_4, out logic_uScriptAct_GetAnimationState_animLength_4, out logic_uScriptAct_GetAnimationState_speed_4, out logic_uScriptAct_GetAnimationState_layer_4, out logic_uScriptAct_GetAnimationState_wrapMode_4);
      local_20_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_Finished_5()
   {
   }
   
   void Relay_In_5()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_18);
            logic_uScriptAct_PlayAnimation_Target_5 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_5 = local_2_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_5.In(logic_uScriptAct_PlayAnimation_Target_5, logic_uScriptAct_PlayAnimation_Animation_5, logic_uScriptAct_PlayAnimation_SpeedFactor_5, logic_uScriptAct_PlayAnimation_AnimWrapMode_5, logic_uScriptAct_PlayAnimation_StopOtherAnimations_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_6()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_Out_7()
   {
      Relay_In_5();
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_7 = owner_Connection_18;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_7 = local_2_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_7 = local_17_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_7.In(logic_uScriptAct_SetAnimationPosition_target_7, logic_uScriptAct_SetAnimationPosition_animationName_7, logic_uScriptAct_SetAnimationPosition_normalizedPosition_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_Out_9()
   {
      Relay_In_14();
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_9 = owner_Connection_18;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_9 = local_11_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_9 = local_16_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_9.In(logic_uScriptAct_SetAnimationPosition_target_9, logic_uScriptAct_SetAnimationPosition_animationName_9, logic_uScriptAct_SetAnimationPosition_normalizedPosition_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_10 = local_17_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.In(logic_uScriptCon_CompareFloat_A_10, logic_uScriptCon_CompareFloat_B_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
      if ( test_1 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_12 = owner_Connection_18;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_12 = local_15_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.In(logic_uScriptAct_GetAnimationState_target_12, logic_uScriptAct_GetAnimationState_animationName_12, out logic_uScriptAct_GetAnimationState_weight_12, out logic_uScriptAct_GetAnimationState_normalizedPosition_12, out logic_uScriptAct_GetAnimationState_animLength_12, out logic_uScriptAct_GetAnimationState_speed_12, out logic_uScriptAct_GetAnimationState_layer_12, out logic_uScriptAct_GetAnimationState_wrapMode_12);
      local_22_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_12;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_12.Out;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_13 = local_16_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.In(logic_uScriptCon_CompareFloat_A_13, logic_uScriptCon_CompareFloat_B_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_13.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
      if ( test_1 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_Finished_14()
   {
   }
   
   void Relay_In_14()
   {
      {
         {
            List<UnityEngine.GameObject> properties = new List<UnityEngine.GameObject>();
            properties.Add((UnityEngine.GameObject)owner_Connection_18);
            logic_uScriptAct_PlayAnimation_Target_14 = properties.ToArray();
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_14 = local_11_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_14.In(logic_uScriptAct_PlayAnimation_Target_14, logic_uScriptAct_PlayAnimation_Animation_14, logic_uScriptAct_PlayAnimation_SpeedFactor_14, logic_uScriptAct_PlayAnimation_AnimWrapMode_14, logic_uScriptAct_PlayAnimation_StopOtherAnimations_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_19()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_19 = local_20_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19.In(logic_uScriptAct_SubtractFloat_A_19, logic_uScriptAct_SubtractFloat_B_19, out logic_uScriptAct_SubtractFloat_FloatResult_19, out logic_uScriptAct_SubtractFloat_IntResult_19);
      local_17_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_21()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_21 = local_22_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_21.In(logic_uScriptAct_SubtractFloat_A_21, logic_uScriptAct_SubtractFloat_B_21, out logic_uScriptAct_SubtractFloat_FloatResult_21, out logic_uScriptAct_SubtractFloat_IntResult_21);
      local_16_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
}
