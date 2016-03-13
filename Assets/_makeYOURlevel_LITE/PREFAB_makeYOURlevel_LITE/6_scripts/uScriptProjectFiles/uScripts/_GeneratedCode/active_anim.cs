//uScript Generated Code - Build 1.0.3018
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
   [Multiline(3)]
   public System.String Close = "";
   System.Single local_11_System_Single = (float) 0;
   System.Single local_12_System_Single = (float) 0;
   System.Single local_15_System_Single = (float) 0;
   System.Single local_17_System_Single = (float) 0;
   [Multiline(3)]
   public System.String Open = "";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_13 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_1 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_1 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetAnimationState_animationName_1 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_1;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_1;
   System.Single logic_uScriptAct_GetAnimationState_animLength_1;
   System.Single logic_uScriptAct_GetAnimationState_speed_1;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_1;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_1;
   bool logic_uScriptAct_GetAnimationState_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_2 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_2 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_2 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_2 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_2 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_3 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_4 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_4 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SetAnimationPosition_animationName_4 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_4 = (float) 0;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_6 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SetAnimationPosition_animationName_6 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_6 = (float) 0;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_7 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_7 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_7 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_7 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_8 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetAnimationState_animationName_8 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_8;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_8;
   System.Single logic_uScriptAct_GetAnimationState_animLength_8;
   System.Single logic_uScriptAct_GetAnimationState_speed_8;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_8;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_8;
   bool logic_uScriptAct_GetAnimationState_Out_8 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_9 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_9 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_9 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_9 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_10 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_10 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_10 = (float) 1;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_10 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_10 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_14 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_14 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_14 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_14;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_14;
   bool logic_uScriptAct_SubtractFloat_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_16 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_16 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_16 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_16;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_16;
   bool logic_uScriptAct_SubtractFloat_Out_16 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_54 = default(UnityEngine.GameObject);
   
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
               uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_54;
                  component.OnExitTrigger += Instance_OnExitTrigger_54;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_54;
               }
            }
         }
      }
      if ( null == owner_Connection_13 || false == m_RegisteredForEvents )
      {
         owner_Connection_13 = parentGameObject;
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
               uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_54;
                  component.OnExitTrigger += Instance_OnExitTrigger_54;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_54;
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
            uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_54;
               component.OnExitTrigger -= Instance_OnExitTrigger_54;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_54;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_1.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_3.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_4.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_14.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_16.SetParent(g);
      owner_Connection_0 = parentGameObject;
      owner_Connection_13 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2.Finished += uScriptAct_PlayAnimation_Finished_2;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_4.Out += uScriptAct_SetAnimationPosition_Out_4;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.Out += uScriptAct_SetAnimationPosition_Out_6;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10.Finished += uScriptAct_PlayAnimation_Finished_10;
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
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2.Finished -= uScriptAct_PlayAnimation_Finished_2;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_4.Out -= uScriptAct_SetAnimationPosition_Out_4;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.Out -= uScriptAct_SetAnimationPosition_Out_6;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10.Finished -= uScriptAct_PlayAnimation_Finished_10;
   }
   
   void Instance_OnEnterTrigger_54(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_54 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_54( );
   }
   
   void Instance_OnExitTrigger_54(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_54 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_54( );
   }
   
   void Instance_WhileInsideTrigger_54(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_54 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_54( );
   }
   
   void uScriptAct_PlayAnimation_Finished_2(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_2( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_4( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_6( );
   }
   
   void uScriptAct_PlayAnimation_Finished_10(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_10( );
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_1 = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_1 = Close;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_1.In(logic_uScriptAct_GetAnimationState_target_1, logic_uScriptAct_GetAnimationState_animationName_1, out logic_uScriptAct_GetAnimationState_weight_1, out logic_uScriptAct_GetAnimationState_normalizedPosition_1, out logic_uScriptAct_GetAnimationState_animLength_1, out logic_uScriptAct_GetAnimationState_speed_1, out logic_uScriptAct_GetAnimationState_layer_1, out logic_uScriptAct_GetAnimationState_wrapMode_1);
      local_15_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_1.Out;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
   }
   
   void Relay_Finished_2()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_2, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_2[ index++ ] = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_2 = Open;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_2.In(logic_uScriptAct_PlayAnimation_Target_2, logic_uScriptAct_PlayAnimation_Animation_2, logic_uScriptAct_PlayAnimation_SpeedFactor_2, logic_uScriptAct_PlayAnimation_AnimWrapMode_2, logic_uScriptAct_PlayAnimation_StopOtherAnimations_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_3()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_3.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
   void Relay_Out_4()
   {
      Relay_In_2();
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_4 = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_4 = Open;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_4 = local_12_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_4.In(logic_uScriptAct_SetAnimationPosition_target_4, logic_uScriptAct_SetAnimationPosition_animationName_4, logic_uScriptAct_SetAnimationPosition_normalizedPosition_4);
      
   }
   
   void Relay_In_5()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Out_6()
   {
      Relay_In_10();
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_6 = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_6 = Close;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_6 = local_11_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.In(logic_uScriptAct_SetAnimationPosition_target_6, logic_uScriptAct_SetAnimationPosition_animationName_6, logic_uScriptAct_SetAnimationPosition_normalizedPosition_6);
      
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_7 = local_12_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.In(logic_uScriptCon_CompareFloat_A_7, logic_uScriptCon_CompareFloat_B_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
      if ( test_1 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_8 = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_8 = Open;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.In(logic_uScriptAct_GetAnimationState_target_8, logic_uScriptAct_GetAnimationState_animationName_8, out logic_uScriptAct_GetAnimationState_weight_8, out logic_uScriptAct_GetAnimationState_normalizedPosition_8, out logic_uScriptAct_GetAnimationState_animLength_8, out logic_uScriptAct_GetAnimationState_speed_8, out logic_uScriptAct_GetAnimationState_layer_8, out logic_uScriptAct_GetAnimationState_wrapMode_8);
      local_17_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_8;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_9 = local_11_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.In(logic_uScriptCon_CompareFloat_A_9, logic_uScriptCon_CompareFloat_B_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
      if ( test_1 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_Finished_10()
   {
   }
   
   void Relay_In_10()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_10.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_10, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_10[ index++ ] = owner_Connection_13;
            
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_10 = Close;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_10.In(logic_uScriptAct_PlayAnimation_Target_10, logic_uScriptAct_PlayAnimation_Animation_10, logic_uScriptAct_PlayAnimation_SpeedFactor_10, logic_uScriptAct_PlayAnimation_AnimWrapMode_10, logic_uScriptAct_PlayAnimation_StopOtherAnimations_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_14()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_14 = local_15_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_14.In(logic_uScriptAct_SubtractFloat_A_14, logic_uScriptAct_SubtractFloat_B_14, out logic_uScriptAct_SubtractFloat_FloatResult_14, out logic_uScriptAct_SubtractFloat_IntResult_14);
      local_12_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_14;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_16 = local_17_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_16.In(logic_uScriptAct_SubtractFloat_A_16, logic_uScriptAct_SubtractFloat_B_16, out logic_uScriptAct_SubtractFloat_FloatResult_16, out logic_uScriptAct_SubtractFloat_IntResult_16);
      local_11_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_16;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_16.Out;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_OnEnterTrigger_54()
   {
      Relay_In_3();
   }
   
   void Relay_OnExitTrigger_54()
   {
      Relay_In_5();
   }
   
   void Relay_WhileInsideTrigger_54()
   {
   }
   
}
