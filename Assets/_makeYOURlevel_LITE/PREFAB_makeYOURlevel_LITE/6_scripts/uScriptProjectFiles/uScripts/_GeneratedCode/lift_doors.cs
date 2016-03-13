//uScript Generated Code - Build 1.0.3018
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class lift_doors : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_1_System_String = "lift_open";
   System.String local_10_System_String = "lift_close";
   System.String local_14_System_String = "lift_open";
   System.Single local_15_System_Single = (float) 0;
   System.Single local_16_System_Single = (float) 0;
   System.Single local_18_System_Single = (float) 0;
   System.String local_2_System_String = "lift_close";
   System.Single local_20_System_Single = (float) 0;
   System.String local_23_System_String = "";
   System.String local_29_System_String = "";
   UnityEngine.GameObject local_33_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_33_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_34_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_34_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_26 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_3 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_3 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetAnimationState_animationName_3 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_3;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_3;
   System.Single logic_uScriptAct_GetAnimationState_animLength_3;
   System.Single logic_uScriptAct_GetAnimationState_speed_3;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_3;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_3;
   bool logic_uScriptAct_GetAnimationState_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_4 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_4 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_4 = (float) 2;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_4 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_4 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_6 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SetAnimationPosition_animationName_6 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_6 = (float) 0;
   //pointer to script instanced logic node
   uScriptAct_Passthrough logic_uScriptAct_Passthrough_uScriptAct_Passthrough_7 = new uScriptAct_Passthrough( );
   bool logic_uScriptAct_Passthrough_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_SetAnimationPosition logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_8 = new uScriptAct_SetAnimationPosition( );
   UnityEngine.GameObject logic_uScriptAct_SetAnimationPosition_target_8 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SetAnimationPosition_animationName_8 = "";
   System.Single logic_uScriptAct_SetAnimationPosition_normalizedPosition_8 = (float) 0;
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
   uScriptAct_GetAnimationState logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_11 = new uScriptAct_GetAnimationState( );
   UnityEngine.GameObject logic_uScriptAct_GetAnimationState_target_11 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetAnimationState_animationName_11 = "";
   System.Single logic_uScriptAct_GetAnimationState_weight_11;
   System.Single logic_uScriptAct_GetAnimationState_normalizedPosition_11;
   System.Single logic_uScriptAct_GetAnimationState_animLength_11;
   System.Single logic_uScriptAct_GetAnimationState_speed_11;
   System.Int32 logic_uScriptAct_GetAnimationState_layer_11;
   UnityEngine.WrapMode logic_uScriptAct_GetAnimationState_wrapMode_11;
   bool logic_uScriptAct_GetAnimationState_Out_11 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_12 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_12 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_12 = (float) 1;
   bool logic_uScriptCon_CompareFloat_GreaterThan_12 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_12 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_12 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_12 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_12 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_12 = true;
   //pointer to script instanced logic node
   uScriptAct_PlayAnimation logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13 = new uScriptAct_PlayAnimation( );
   UnityEngine.GameObject[] logic_uScriptAct_PlayAnimation_Target_13 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_PlayAnimation_Animation_13 = "";
   System.Single logic_uScriptAct_PlayAnimation_SpeedFactor_13 = (float) 2;
   UnityEngine.WrapMode logic_uScriptAct_PlayAnimation_AnimWrapMode_13 = UnityEngine.WrapMode.Default;
   System.Boolean logic_uScriptAct_PlayAnimation_StopOtherAnimations_13 = (bool) true;
   bool logic_uScriptAct_PlayAnimation_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_17 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_17 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_17;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_17;
   bool logic_uScriptAct_SubtractFloat_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_19 = (float) 1;
   System.Single logic_uScriptAct_SubtractFloat_B_19 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_19;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_19;
   bool logic_uScriptAct_SubtractFloat_Out_19 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_22 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_22 = "";
   System.String logic_uScriptCon_CompareString_B_22 = "stop";
   bool logic_uScriptCon_CompareString_Same_22 = true;
   bool logic_uScriptCon_CompareString_Different_22 = true;
   //pointer to script instanced logic node
   uScriptCon_Gate logic_uScriptCon_Gate_uScriptCon_Gate_24 = new uScriptCon_Gate( );
   System.Boolean logic_uScriptCon_Gate_StartOpen_24 = (bool) true;
   System.Int32 logic_uScriptCon_Gate_AutoCloseCount_24 = (int) 0;
   System.Boolean logic_uScriptCon_Gate_IsOpen_24;
   //pointer to script instanced logic node
   uScriptCon_Gate logic_uScriptCon_Gate_uScriptCon_Gate_25 = new uScriptCon_Gate( );
   System.Boolean logic_uScriptCon_Gate_StartOpen_25 = (bool) true;
   System.Int32 logic_uScriptCon_Gate_AutoCloseCount_25 = (int) 0;
   System.Boolean logic_uScriptCon_Gate_IsOpen_25;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_28 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_28 = "";
   System.String logic_uScriptCon_CompareString_B_28 = "go";
   bool logic_uScriptCon_CompareString_Same_28 = true;
   bool logic_uScriptCon_CompareString_Different_28 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_31 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_31 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_31;
   bool logic_uScriptAct_GetParent_Out_31 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_32 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_32 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_32;
   bool logic_uScriptAct_GetParent_Out_32 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Sender_21 = default(UnityEngine.GameObject);
   System.String event_UnityEngine_GameObject_EventName_21 = "";
   UnityEngine.GameObject event_UnityEngine_GameObject_Sender_27 = default(UnityEngine.GameObject);
   System.String event_UnityEngine_GameObject_EventName_27 = "";
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_35 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_34_UnityEngine_GameObject_previous )
         {
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_21;
               }
            }
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_27;
               }
            }
         }
         
         local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_34_UnityEngine_GameObject )
         {
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_21;
               }
            }
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_27;
               }
            }
         }
      }
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
                  component.OnEnterTrigger += Instance_OnEnterTrigger_35;
                  component.OnExitTrigger += Instance_OnExitTrigger_35;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_35;
               }
            }
         }
      }
      if ( null == owner_Connection_26 || false == m_RegisteredForEvents )
      {
         owner_Connection_26 = parentGameObject;
         if ( null != owner_Connection_26 )
         {
            {
               uScript_Global component = owner_Connection_26.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_26.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_30;
                  component.uScriptLateStart += Instance_uScriptLateStart_30;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_34_UnityEngine_GameObject_previous )
         {
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_21;
               }
            }
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
               if ( null != component )
               {
                  component.OnCustomEvent -= Instance_OnCustomEvent_27;
               }
            }
         }
         
         local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_34_UnityEngine_GameObject )
         {
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_21;
               }
            }
            {
               uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_27;
               }
            }
         }
      }
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
                  component.OnEnterTrigger += Instance_OnEnterTrigger_35;
                  component.OnExitTrigger += Instance_OnExitTrigger_35;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_35;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_26 )
         {
            {
               uScript_Global component = owner_Connection_26.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_26.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_30;
                  component.uScriptLateStart += Instance_uScriptLateStart_30;
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
      if ( null != local_34_UnityEngine_GameObject )
      {
         {
            uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
            if ( null != component )
            {
               component.OnCustomEvent -= Instance_OnCustomEvent_21;
            }
         }
         {
            uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
            if ( null != component )
            {
               component.OnCustomEvent -= Instance_OnCustomEvent_27;
            }
         }
      }
      if ( null != owner_Connection_0 )
      {
         {
            uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_35;
               component.OnExitTrigger -= Instance_OnExitTrigger_35;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_35;
            }
         }
      }
      if ( null != owner_Connection_26 )
      {
         {
            uScript_Global component = owner_Connection_26.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_30;
               component.uScriptLateStart -= Instance_uScriptLateStart_30;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_3.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_5.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.SetParent(g);
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_7.SetParent(g);
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_8.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.SetParent(g);
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_11.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_12.SetParent(g);
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_22.SetParent(g);
      logic_uScriptCon_Gate_uScriptCon_Gate_24.SetParent(g);
      logic_uScriptCon_Gate_uScriptCon_Gate_25.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_28.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_31.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_32.SetParent(g);
      owner_Connection_0 = parentGameObject;
      owner_Connection_26 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4.Finished += uScriptAct_PlayAnimation_Finished_4;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.Out += uScriptAct_SetAnimationPosition_Out_6;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_8.Out += uScriptAct_SetAnimationPosition_Out_8;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13.Finished += uScriptAct_PlayAnimation_Finished_13;
      logic_uScriptCon_Gate_uScriptCon_Gate_24.Out += uScriptCon_Gate_Out_24;
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Out += uScriptCon_Gate_Out_25;
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
      
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4.Update( );
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4.Finished -= uScriptAct_PlayAnimation_Finished_4;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.Out -= uScriptAct_SetAnimationPosition_Out_6;
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_8.Out -= uScriptAct_SetAnimationPosition_Out_8;
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13.Finished -= uScriptAct_PlayAnimation_Finished_13;
      logic_uScriptCon_Gate_uScriptCon_Gate_24.Out -= uScriptCon_Gate_Out_24;
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Out -= uScriptCon_Gate_Out_25;
   }
   
   void Instance_OnCustomEvent_21(object o, uScript_CustomEvent.CustomEventBoolArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Sender_21 = e.Sender;
      event_UnityEngine_GameObject_EventName_21 = e.EventName;
      //relay event to nodes
      Relay_OnCustomEvent_21( );
   }
   
   void Instance_OnCustomEvent_27(object o, uScript_CustomEvent.CustomEventBoolArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Sender_27 = e.Sender;
      event_UnityEngine_GameObject_EventName_27 = e.EventName;
      //relay event to nodes
      Relay_OnCustomEvent_27( );
   }
   
   void Instance_uScriptStart_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_30( );
   }
   
   void Instance_uScriptLateStart_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_30( );
   }
   
   void Instance_OnEnterTrigger_35(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_35 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_35( );
   }
   
   void Instance_OnExitTrigger_35(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_35 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_35( );
   }
   
   void Instance_WhileInsideTrigger_35(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_35 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_35( );
   }
   
   void uScriptAct_PlayAnimation_Finished_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_4( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_6( );
   }
   
   void uScriptAct_SetAnimationPosition_Out_8(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Out_8( );
   }
   
   void uScriptAct_PlayAnimation_Finished_13(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_13( );
   }
   
   void uScriptCon_Gate_Out_24(object o, System.EventArgs e)
   {
      //fill globals
      //links to IsOpen = 0
      //relay event to nodes
      Relay_Out_24( );
   }
   
   void uScriptCon_Gate_Out_25(object o, System.EventArgs e)
   {
      //fill globals
      //links to IsOpen = 0
      //relay event to nodes
      Relay_Out_25( );
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_3 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_3 = local_2_System_String;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_3.In(logic_uScriptAct_GetAnimationState_target_3, logic_uScriptAct_GetAnimationState_animationName_3, out logic_uScriptAct_GetAnimationState_weight_3, out logic_uScriptAct_GetAnimationState_normalizedPosition_3, out logic_uScriptAct_GetAnimationState_animLength_3, out logic_uScriptAct_GetAnimationState_speed_3, out logic_uScriptAct_GetAnimationState_layer_3, out logic_uScriptAct_GetAnimationState_wrapMode_3);
      local_18_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_Finished_4()
   {
      Relay_Open_25();
   }
   
   void Relay_In_4()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_4, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_4[ index++ ] = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_4 = local_1_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_4.In(logic_uScriptAct_PlayAnimation_Target_4, logic_uScriptAct_PlayAnimation_Animation_4, logic_uScriptAct_PlayAnimation_SpeedFactor_4, logic_uScriptAct_PlayAnimation_AnimWrapMode_4, logic_uScriptAct_PlayAnimation_StopOtherAnimations_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
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
         Relay_In_3();
      }
   }
   
   void Relay_Out_6()
   {
      Relay_In_4();
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_6 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_6 = local_1_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_6 = local_16_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_6.In(logic_uScriptAct_SetAnimationPosition_target_6, logic_uScriptAct_SetAnimationPosition_animationName_6, logic_uScriptAct_SetAnimationPosition_normalizedPosition_6);
      
   }
   
   void Relay_In_7()
   {
      {
      }
      logic_uScriptAct_Passthrough_uScriptAct_Passthrough_7.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Passthrough_uScriptAct_Passthrough_7.Out;
      
      if ( test_0 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_Out_8()
   {
      Relay_In_13();
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_SetAnimationPosition_target_8 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_animationName_8 = local_10_System_String;
            
         }
         {
            logic_uScriptAct_SetAnimationPosition_normalizedPosition_8 = local_15_System_Single;
            
         }
      }
      logic_uScriptAct_SetAnimationPosition_uScriptAct_SetAnimationPosition_8.In(logic_uScriptAct_SetAnimationPosition_target_8, logic_uScriptAct_SetAnimationPosition_animationName_8, logic_uScriptAct_SetAnimationPosition_normalizedPosition_8);
      
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_9 = local_16_System_Single;
            
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
         Relay_In_4();
      }
      if ( test_1 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptAct_GetAnimationState_target_11 = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_GetAnimationState_animationName_11 = local_14_System_String;
            
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
      logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_11.In(logic_uScriptAct_GetAnimationState_target_11, logic_uScriptAct_GetAnimationState_animationName_11, out logic_uScriptAct_GetAnimationState_weight_11, out logic_uScriptAct_GetAnimationState_normalizedPosition_11, out logic_uScriptAct_GetAnimationState_animLength_11, out logic_uScriptAct_GetAnimationState_speed_11, out logic_uScriptAct_GetAnimationState_layer_11, out logic_uScriptAct_GetAnimationState_wrapMode_11);
      local_20_System_Single = logic_uScriptAct_GetAnimationState_normalizedPosition_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetAnimationState_uScriptAct_GetAnimationState_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_12 = local_15_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_12.In(logic_uScriptCon_CompareFloat_A_12, logic_uScriptCon_CompareFloat_B_12);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_12.EqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_12.NotEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
      if ( test_1 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Finished_13()
   {
   }
   
   void Relay_In_13()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_PlayAnimation_Target_13.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlayAnimation_Target_13, index + 1);
            }
            logic_uScriptAct_PlayAnimation_Target_13[ index++ ] = owner_Connection_0;
            
         }
         {
            logic_uScriptAct_PlayAnimation_Animation_13 = local_10_System_String;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlayAnimation_uScriptAct_PlayAnimation_13.In(logic_uScriptAct_PlayAnimation_Target_13, logic_uScriptAct_PlayAnimation_Animation_13, logic_uScriptAct_PlayAnimation_SpeedFactor_13, logic_uScriptAct_PlayAnimation_AnimWrapMode_13, logic_uScriptAct_PlayAnimation_StopOtherAnimations_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_17()
   {
      {
         {
         }
         {
            logic_uScriptAct_SubtractFloat_B_17 = local_18_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.In(logic_uScriptAct_SubtractFloat_A_17, logic_uScriptAct_SubtractFloat_B_17, out logic_uScriptAct_SubtractFloat_FloatResult_17, out logic_uScriptAct_SubtractFloat_IntResult_17);
      local_16_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_17.Out;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
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
      local_15_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_OnCustomEvent_21()
   {
      local_23_System_String = event_UnityEngine_GameObject_EventName_21;
      Relay_In_22();
   }
   
   void Relay_In_22()
   {
      {
         {
            logic_uScriptCon_CompareString_A_22 = local_23_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_22.In(logic_uScriptCon_CompareString_A_22, logic_uScriptCon_CompareString_B_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_22.Same;
      
      if ( test_0 == true )
      {
         Relay_Close_24();
         Relay_Close_25();
      }
   }
   
   void Relay_Out_24()
   {
      Relay_In_5();
   }
   
   void Relay_In_24()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_24.In(logic_uScriptCon_Gate_StartOpen_24, logic_uScriptCon_Gate_AutoCloseCount_24, out logic_uScriptCon_Gate_IsOpen_24);
      
   }
   
   void Relay_Open_24()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_24.Open(logic_uScriptCon_Gate_StartOpen_24, logic_uScriptCon_Gate_AutoCloseCount_24, out logic_uScriptCon_Gate_IsOpen_24);
      
   }
   
   void Relay_Close_24()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_24.Close(logic_uScriptCon_Gate_StartOpen_24, logic_uScriptCon_Gate_AutoCloseCount_24, out logic_uScriptCon_Gate_IsOpen_24);
      
   }
   
   void Relay_Toggle_24()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_24.Toggle(logic_uScriptCon_Gate_StartOpen_24, logic_uScriptCon_Gate_AutoCloseCount_24, out logic_uScriptCon_Gate_IsOpen_24);
      
   }
   
   void Relay_Out_25()
   {
      Relay_In_7();
   }
   
   void Relay_In_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.In(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
   }
   
   void Relay_Open_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Open(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
   }
   
   void Relay_Close_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Close(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
   }
   
   void Relay_Toggle_25()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_Gate_uScriptCon_Gate_25.Toggle(logic_uScriptCon_Gate_StartOpen_25, logic_uScriptCon_Gate_AutoCloseCount_25, out logic_uScriptCon_Gate_IsOpen_25);
      
   }
   
   void Relay_OnCustomEvent_27()
   {
      local_29_System_String = event_UnityEngine_GameObject_EventName_27;
      Relay_In_28();
   }
   
   void Relay_In_28()
   {
      {
         {
            logic_uScriptCon_CompareString_A_28 = local_29_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_28.In(logic_uScriptCon_CompareString_A_28, logic_uScriptCon_CompareString_B_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_28.Same;
      
      if ( test_0 == true )
      {
         Relay_Open_24();
      }
   }
   
   void Relay_uScriptStart_30()
   {
      Relay_In_31();
   }
   
   void Relay_uScriptLateStart_30()
   {
   }
   
   void Relay_In_31()
   {
      {
         {
            logic_uScriptAct_GetParent_Target_31 = owner_Connection_26;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_31.In(logic_uScriptAct_GetParent_Target_31, out logic_uScriptAct_GetParent_Parent_31);
      local_33_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_31;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_31.Out;
      
      if ( test_0 == true )
      {
         Relay_In_32();
      }
   }
   
   void Relay_In_32()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_32 = local_33_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_32.In(logic_uScriptAct_GetParent_Target_32, out logic_uScriptAct_GetParent_Parent_32);
      local_34_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_32;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_34_UnityEngine_GameObject_previous != local_34_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            if ( null != local_34_UnityEngine_GameObject_previous )
            {
               {
                  uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
                  if ( null != component )
                  {
                     component.OnCustomEvent -= Instance_OnCustomEvent_21;
                  }
               }
               {
                  uScript_CustomEvent component = local_34_UnityEngine_GameObject_previous.GetComponent<uScript_CustomEvent>();
                  if ( null != component )
                  {
                     component.OnCustomEvent -= Instance_OnCustomEvent_27;
                  }
               }
            }
            
            local_34_UnityEngine_GameObject_previous = local_34_UnityEngine_GameObject;
            
            //setup new listeners
            if ( null != local_34_UnityEngine_GameObject )
            {
               {
                  uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
                  if ( null == component )
                  {
                     component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
                  }
                  if ( null != component )
                  {
                     component.OnCustomEvent += Instance_OnCustomEvent_21;
                  }
               }
               {
                  uScript_CustomEvent component = local_34_UnityEngine_GameObject.GetComponent<uScript_CustomEvent>();
                  if ( null == component )
                  {
                     component = local_34_UnityEngine_GameObject.AddComponent<uScript_CustomEvent>();
                  }
                  if ( null != component )
                  {
                     component.OnCustomEvent += Instance_OnCustomEvent_27;
                  }
               }
            }
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_35()
   {
      Relay_In_24();
   }
   
   void Relay_OnExitTrigger_35()
   {
      Relay_In_25();
   }
   
   void Relay_WhileInsideTrigger_35()
   {
   }
   
}
