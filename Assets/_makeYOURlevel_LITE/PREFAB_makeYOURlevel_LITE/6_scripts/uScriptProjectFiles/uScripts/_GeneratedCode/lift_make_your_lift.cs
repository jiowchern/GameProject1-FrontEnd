//uScript Generated Code - Build 1.0.3018
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class lift_make_your_lift : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _Person_Controller = default(UnityEngine.GameObject);
   UnityEngine.GameObject _Person_Controller_previous = null;
   public UnityEngine.KeyCode BOTTOM = UnityEngine.KeyCode.None;
   UnityEngine.GameObject local_10_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_10_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_12_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_12_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_39_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_39_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_41_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_41_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_43_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_43_UnityEngine_GameObject_previous = null;
   System.String local_46_System_String = "";
   System.String local_48_System_String = "";
   System.String local_50_System_String = "";
   UnityEngine.GameObject local_etage_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_etage_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_lift_active_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_lift_make_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_lift_make_your_lift_UnityEngine_GameObject_previous = null;
   public UnityEngine.KeyCode TOP = UnityEngine.KeyCode.None;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_0 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_0 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_0 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_0 = (bool) true;
   System.Boolean logic_uScriptCon_CompareGameObjects_ReportNull_0 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_0 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_0 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_2 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_2 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_2 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_2 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_2 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_2;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_2;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_2;
   bool logic_uScriptAct_GetChildrenByName_Out_2 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_2 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_3 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_3;
   bool logic_uScriptAct_GetParent_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_Teleport logic_uScriptAct_Teleport_uScriptAct_Teleport_4 = new uScriptAct_Teleport( );
   UnityEngine.GameObject[] logic_uScriptAct_Teleport_Target_4 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_Teleport_Destination_4 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_Teleport_UpdateRotation_4 = (bool) false;
   bool logic_uScriptAct_Teleport_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_5 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_5 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_5 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_5 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_5 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_5 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_7 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_7 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_7;
   bool logic_uScriptAct_GetParent_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_8 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_8 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_8 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_8 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_8 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_8;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_8;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_8;
   bool logic_uScriptAct_GetChildrenByName_Out_8 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_8 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_14 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_14;
   bool logic_uScriptAct_GetParent_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_16 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_16 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_16 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_16 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_16 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_18 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_18 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_18 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_18 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_18;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_18;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_18;
   bool logic_uScriptAct_GetChildrenByName_Out_18 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_18 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_18 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_19 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_19 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_19 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_19 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_19 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_19 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_21 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_21 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_21 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_21 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_24 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_24 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_24 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_24 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_24 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_24;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_24;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_24;
   bool logic_uScriptAct_GetChildrenByName_Out_24 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_24 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_24 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_25 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_25 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_25;
   bool logic_uScriptAct_GetParent_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_26 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_26 = new Vector3( (float)0, (float)3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_26 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_26 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_26 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_26 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_28 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_28 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_28 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_28 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_29 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_29 = new Vector3( (float)0, (float)-3.2, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_29 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_29 = (float) 2;
   bool logic_uScriptAct_MoveToLocationRelative_Out_29 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_29 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_30 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_30 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_30 = "lift_active";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_30 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_30 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_30;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_30;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_30;
   bool logic_uScriptAct_GetChildrenByName_Out_30 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_30 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_30 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_34 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_34 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_34;
   bool logic_uScriptAct_GetParent_Out_34 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_37 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_37 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_37 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_37 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_37 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_38 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_38 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_38;
   bool logic_uScriptAct_GetParent_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_40 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_40 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_40;
   bool logic_uScriptAct_GetParent_Out_40 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_42 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_42 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_42;
   bool logic_uScriptAct_GetParent_Out_42 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_44 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_44 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_44;
   bool logic_uScriptAct_GetGameObjectName_Out_44 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_45 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_45 = "";
   System.String logic_uScriptCon_CompareString_B_45 = "detect_lift_last";
   bool logic_uScriptCon_CompareString_Same_45 = true;
   bool logic_uScriptCon_CompareString_Different_45 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_47 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_47 = "";
   System.String logic_uScriptCon_CompareString_B_47 = "detect_lift_1st";
   bool logic_uScriptCon_CompareString_Same_47 = true;
   bool logic_uScriptCon_CompareString_Different_47 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_49 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_49 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_49;
   bool logic_uScriptAct_GetGameObjectName_Out_49 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_51 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_51 = "";
   System.String logic_uScriptCon_CompareString_B_51 = "detect_lift_middle";
   bool logic_uScriptCon_CompareString_Same_51 = true;
   bool logic_uScriptCon_CompareString_Different_51 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_52 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_52 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_52;
   bool logic_uScriptAct_GetGameObjectName_Out_52 = true;
   //pointer to script instanced logic node
   uScriptAct_SendCustomEvent logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_53 = new uScriptAct_SendCustomEvent( );
   System.String logic_uScriptAct_SendCustomEvent_EventName_53 = "stop";
   uScriptCustomEvent.SendGroup logic_uScriptAct_SendCustomEvent_sendGroup_53 = uScriptCustomEvent.SendGroup.Children;
   UnityEngine.GameObject logic_uScriptAct_SendCustomEvent_EventSender_53 = default(UnityEngine.GameObject);
   bool logic_uScriptAct_SendCustomEvent_Out_53 = true;
   //pointer to script instanced logic node
   uScriptAct_SendCustomEvent logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54 = new uScriptAct_SendCustomEvent( );
   System.String logic_uScriptAct_SendCustomEvent_EventName_54 = "go";
   uScriptCustomEvent.SendGroup logic_uScriptAct_SendCustomEvent_sendGroup_54 = uScriptCustomEvent.SendGroup.Children;
   UnityEngine.GameObject logic_uScriptAct_SendCustomEvent_EventSender_54 = default(UnityEngine.GameObject);
   bool logic_uScriptAct_SendCustomEvent_Out_54 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_55 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptCon_CompareGameObjects_B_0 || false == m_RegisteredForEvents )
      {
         logic_uScriptCon_CompareGameObjects_B_0 = GameObject.Find( "detect_floor" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == _Person_Controller || false == m_RegisteredForEvents )
      {
         _Person_Controller = GameObject.Find( "First Person Controller" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Person_Controller_previous != _Person_Controller || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != _Person_Controller_previous )
         {
            {
               uScript_Trigger component = _Person_Controller_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                  component.OnExitTrigger -= Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
               }
            }
         }
         
         _Person_Controller_previous = _Person_Controller;
         
         //setup new listeners
         if ( null != _Person_Controller )
         {
            {
               uScript_Trigger component = _Person_Controller.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                  component.OnExitTrigger += Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_39_UnityEngine_GameObject_previous != local_39_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_39_UnityEngine_GameObject_previous = local_39_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_41_UnityEngine_GameObject_previous != local_41_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_41_UnityEngine_GameObject_previous = local_41_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Person_Controller_previous != _Person_Controller || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != _Person_Controller_previous )
         {
            {
               uScript_Trigger component = _Person_Controller_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                  component.OnExitTrigger -= Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
               }
            }
         }
         
         _Person_Controller_previous = _Person_Controller;
         
         //setup new listeners
         if ( null != _Person_Controller )
         {
            {
               uScript_Trigger component = _Person_Controller.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = _Person_Controller.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                  component.OnExitTrigger += Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_39_UnityEngine_GameObject_previous != local_39_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_39_UnityEngine_GameObject_previous = local_39_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_41_UnityEngine_GameObject_previous != local_41_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_41_UnityEngine_GameObject_previous = local_41_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != _Person_Controller )
      {
         {
            uScript_Trigger component = _Person_Controller.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
               component.OnExitTrigger -= Instance_OnExitTrigger_55;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_0.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_2.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_3.SetParent(g);
      logic_uScriptAct_Teleport_uScriptAct_Teleport_4.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_7.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_8.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_14.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_16.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_24.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_25.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_30.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_34.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_37.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_38.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_40.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_42.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_44.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_45.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_47.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_49.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_51.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_52.SetParent(g);
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_53.SetParent(g);
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.Finished += uScriptAct_MoveToLocationRelative_Finished_5;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.Finished += uScriptAct_MoveToLocationRelative_Finished_19;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.Finished += uScriptAct_MoveToLocationRelative_Finished_26;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.Finished += uScriptAct_MoveToLocationRelative_Finished_29;
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
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.Finished -= uScriptAct_MoveToLocationRelative_Finished_5;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.Finished -= uScriptAct_MoveToLocationRelative_Finished_19;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.Finished -= uScriptAct_MoveToLocationRelative_Finished_26;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.Finished -= uScriptAct_MoveToLocationRelative_Finished_29;
   }
   
   void Instance_OnEnterTrigger_55(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_55( );
   }
   
   void Instance_OnExitTrigger_55(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_55( );
   }
   
   void Instance_WhileInsideTrigger_55(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_55( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_5( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_19(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_19( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_26(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_26( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_29( );
   }
   
   void Relay_In_0()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_0 = local_10_UnityEngine_GameObject;
            
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
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_0.In(logic_uScriptCon_CompareGameObjects_A_0, logic_uScriptCon_CompareGameObjects_B_0, logic_uScriptCon_CompareGameObjects_CompareByTag_0, logic_uScriptCon_CompareGameObjects_CompareByName_0, logic_uScriptCon_CompareGameObjects_ReportNull_0);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_0.Same;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_In_2()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_2 = local_lift_make_UnityEngine_GameObject;
            
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_2.In(logic_uScriptAct_GetChildrenByName_Target_2, logic_uScriptAct_GetChildrenByName_Name_2, logic_uScriptAct_GetChildrenByName_SearchMethod_2, logic_uScriptAct_GetChildrenByName_recursive_2, out logic_uScriptAct_GetChildrenByName_FirstChild_2, out logic_uScriptAct_GetChildrenByName_Children_2, out logic_uScriptAct_GetChildrenByName_ChildrenCount_2);
      local_12_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_2;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_2.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_3()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_3 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_3.In(logic_uScriptAct_GetParent_Target_3, out logic_uScriptAct_GetParent_Parent_3);
      local_etage_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Teleport_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Teleport_Target_4, index + 1);
            }
            logic_uScriptAct_Teleport_Target_4[ index++ ] = local_12_UnityEngine_GameObject;
            
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_Teleport_Destination_4 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_Teleport_uScriptAct_Teleport_4.In(logic_uScriptAct_Teleport_Target_4, logic_uScriptAct_Teleport_Destination_4, logic_uScriptAct_Teleport_UpdateRotation_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Finished_5()
   {
      Relay_SendCustomEvent_54();
   }
   
   void Relay_In_5()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_5.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_5, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_5[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_5 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.In(logic_uScriptAct_MoveToLocationRelative_targetArray_5, logic_uScriptAct_MoveToLocationRelative_location_5, logic_uScriptAct_MoveToLocationRelative_source_5, logic_uScriptAct_MoveToLocationRelative_totalTime_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_5()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_5.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_5, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_5[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_5 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_5.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_5, logic_uScriptAct_MoveToLocationRelative_location_5, logic_uScriptAct_MoveToLocationRelative_source_5, logic_uScriptAct_MoveToLocationRelative_totalTime_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_7()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_39_UnityEngine_GameObject_previous != local_39_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_39_UnityEngine_GameObject_previous = local_39_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_7 = local_39_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_7.In(logic_uScriptAct_GetParent_Target_7, out logic_uScriptAct_GetParent_Parent_7);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_7;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_7.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
         Relay_In_37();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_8 = local_lift_make_your_lift_UnityEngine_GameObject;
            
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_8.In(logic_uScriptAct_GetChildrenByName_Target_8, logic_uScriptAct_GetChildrenByName_Name_8, logic_uScriptAct_GetChildrenByName_SearchMethod_8, logic_uScriptAct_GetChildrenByName_recursive_8, out logic_uScriptAct_GetChildrenByName_FirstChild_8, out logic_uScriptAct_GetChildrenByName_Children_8, out logic_uScriptAct_GetChildrenByName_ChildrenCount_8);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_8;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_8.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_14()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_etage_UnityEngine_GameObject_previous != local_etage_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_etage_UnityEngine_GameObject_previous = local_etage_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_14 = local_etage_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_14.In(logic_uScriptAct_GetParent_Target_14, out logic_uScriptAct_GetParent_Parent_14);
      local_lift_make_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_14;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_UnityEngine_GameObject_previous != local_lift_make_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_UnityEngine_GameObject_previous = local_lift_make_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_16 = BOTTOM;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_16.In(logic_uScriptAct_OnInputEventFilter_KeyCode_16);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_16.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_18();
         Relay_SendCustomEvent_53();
      }
   }
   
   void Relay_In_18()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_18 = local_lift_make_your_lift_UnityEngine_GameObject;
            
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.In(logic_uScriptAct_GetChildrenByName_Target_18, logic_uScriptAct_GetChildrenByName_Name_18, logic_uScriptAct_GetChildrenByName_SearchMethod_18, logic_uScriptAct_GetChildrenByName_recursive_18, out logic_uScriptAct_GetChildrenByName_FirstChild_18, out logic_uScriptAct_GetChildrenByName_Children_18, out logic_uScriptAct_GetChildrenByName_ChildrenCount_18);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_18.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_Finished_19()
   {
      Relay_SendCustomEvent_54();
   }
   
   void Relay_In_19()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_19.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_19, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_19[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_19 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.In(logic_uScriptAct_MoveToLocationRelative_targetArray_19, logic_uScriptAct_MoveToLocationRelative_location_19, logic_uScriptAct_MoveToLocationRelative_source_19, logic_uScriptAct_MoveToLocationRelative_totalTime_19);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_19()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_19.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_19, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_19[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_19 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_19.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_19, logic_uScriptAct_MoveToLocationRelative_location_19, logic_uScriptAct_MoveToLocationRelative_source_19, logic_uScriptAct_MoveToLocationRelative_totalTime_19);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_21()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_21 = TOP;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.In(logic_uScriptAct_OnInputEventFilter_KeyCode_21);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_21.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_24();
         Relay_SendCustomEvent_53();
      }
   }
   
   void Relay_In_24()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_24 = local_lift_make_your_lift_UnityEngine_GameObject;
            
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_24.In(logic_uScriptAct_GetChildrenByName_Target_24, logic_uScriptAct_GetChildrenByName_Name_24, logic_uScriptAct_GetChildrenByName_SearchMethod_24, logic_uScriptAct_GetChildrenByName_recursive_24, out logic_uScriptAct_GetChildrenByName_FirstChild_24, out logic_uScriptAct_GetChildrenByName_Children_24, out logic_uScriptAct_GetChildrenByName_ChildrenCount_24);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_24;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_24.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_41_UnityEngine_GameObject_previous != local_41_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_41_UnityEngine_GameObject_previous = local_41_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_25 = local_41_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_25.In(logic_uScriptAct_GetParent_Target_25, out logic_uScriptAct_GetParent_Parent_25);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_25;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_25.Out;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_Finished_26()
   {
      Relay_SendCustomEvent_54();
   }
   
   void Relay_In_26()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_26.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_26, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_26[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_26 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.In(logic_uScriptAct_MoveToLocationRelative_targetArray_26, logic_uScriptAct_MoveToLocationRelative_location_26, logic_uScriptAct_MoveToLocationRelative_source_26, logic_uScriptAct_MoveToLocationRelative_totalTime_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_26()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_26.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_26, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_26[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_26 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_26.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_26, logic_uScriptAct_MoveToLocationRelative_location_26, logic_uScriptAct_MoveToLocationRelative_source_26, logic_uScriptAct_MoveToLocationRelative_totalTime_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_28()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_28 = BOTTOM;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.In(logic_uScriptAct_OnInputEventFilter_KeyCode_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_30();
         Relay_SendCustomEvent_53();
      }
   }
   
   void Relay_Finished_29()
   {
      Relay_SendCustomEvent_54();
   }
   
   void Relay_In_29()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_29.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_29, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_29[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_29 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.In(logic_uScriptAct_MoveToLocationRelative_targetArray_29, logic_uScriptAct_MoveToLocationRelative_location_29, logic_uScriptAct_MoveToLocationRelative_source_29, logic_uScriptAct_MoveToLocationRelative_totalTime_29);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_29()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_29.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_29, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_29[ index++ ] = local_lift_active_UnityEngine_GameObject;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_29 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_29.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_29, logic_uScriptAct_MoveToLocationRelative_location_29, logic_uScriptAct_MoveToLocationRelative_source_29, logic_uScriptAct_MoveToLocationRelative_totalTime_29);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_30()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetChildrenByName_Target_30 = local_lift_make_your_lift_UnityEngine_GameObject;
            
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
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_30.In(logic_uScriptAct_GetChildrenByName_Target_30, logic_uScriptAct_GetChildrenByName_Name_30, logic_uScriptAct_GetChildrenByName_SearchMethod_30, logic_uScriptAct_GetChildrenByName_recursive_30, out logic_uScriptAct_GetChildrenByName_FirstChild_30, out logic_uScriptAct_GetChildrenByName_Children_30, out logic_uScriptAct_GetChildrenByName_ChildrenCount_30);
      local_lift_active_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_30;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_active_UnityEngine_GameObject_previous != local_lift_active_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_active_UnityEngine_GameObject_previous = local_lift_active_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_30.ChildrenFound;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_34()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_34 = local_43_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_34.In(logic_uScriptAct_GetParent_Target_34, out logic_uScriptAct_GetParent_Parent_34);
      local_lift_make_your_lift_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_34;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_lift_make_your_lift_UnityEngine_GameObject_previous != local_lift_make_your_lift_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_lift_make_your_lift_UnityEngine_GameObject_previous = local_lift_make_your_lift_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_34.Out;
      
      if ( test_0 == true )
      {
         Relay_In_28();
      }
   }
   
   void Relay_In_37()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_37 = TOP;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_37.In(logic_uScriptAct_OnInputEventFilter_KeyCode_37);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_37.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_8();
         Relay_SendCustomEvent_53();
      }
   }
   
   void Relay_In_38()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_38 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_38.In(logic_uScriptAct_GetParent_Target_38, out logic_uScriptAct_GetParent_Parent_38);
      local_39_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_38;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_39_UnityEngine_GameObject_previous != local_39_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_39_UnityEngine_GameObject_previous = local_39_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_38.Out;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_40()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_40 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_40.In(logic_uScriptAct_GetParent_Target_40, out logic_uScriptAct_GetParent_Parent_40);
      local_41_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_40;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_41_UnityEngine_GameObject_previous != local_41_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_41_UnityEngine_GameObject_previous = local_41_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_40.Out;
      
      if ( test_0 == true )
      {
         Relay_In_25();
      }
   }
   
   void Relay_In_42()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetParent_Target_42 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetParent_uScriptAct_GetParent_42.In(logic_uScriptAct_GetParent_Target_42, out logic_uScriptAct_GetParent_Parent_42);
      local_43_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_42;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_43_UnityEngine_GameObject_previous != local_43_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_43_UnityEngine_GameObject_previous = local_43_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_42.Out;
      
      if ( test_0 == true )
      {
         Relay_In_34();
      }
   }
   
   void Relay_In_44()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_44 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_44.In(logic_uScriptAct_GetGameObjectName_gameObject_44, out logic_uScriptAct_GetGameObjectName_name_44);
      local_46_System_String = logic_uScriptAct_GetGameObjectName_name_44;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_44.Out;
      
      if ( test_0 == true )
      {
         Relay_In_45();
      }
   }
   
   void Relay_In_45()
   {
      {
         {
            logic_uScriptCon_CompareString_A_45 = local_46_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_45.In(logic_uScriptCon_CompareString_A_45, logic_uScriptCon_CompareString_B_45);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_45.Same;
      
      if ( test_0 == true )
      {
         Relay_In_42();
      }
   }
   
   void Relay_In_47()
   {
      {
         {
            logic_uScriptCon_CompareString_A_47 = local_48_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_47.In(logic_uScriptCon_CompareString_A_47, logic_uScriptCon_CompareString_B_47);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_47.Same;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_In_49()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_49 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_49.In(logic_uScriptAct_GetGameObjectName_gameObject_49, out logic_uScriptAct_GetGameObjectName_name_49);
      local_48_System_String = logic_uScriptAct_GetGameObjectName_name_49;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_49.Out;
      
      if ( test_0 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_In_51()
   {
      {
         {
            logic_uScriptCon_CompareString_A_51 = local_50_System_String;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_51.In(logic_uScriptCon_CompareString_A_51, logic_uScriptCon_CompareString_B_51);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_51.Same;
      
      if ( test_0 == true )
      {
         Relay_In_38();
      }
   }
   
   void Relay_In_52()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_52 = local_10_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_52.In(logic_uScriptAct_GetGameObjectName_gameObject_52, out logic_uScriptAct_GetGameObjectName_name_52);
      local_50_System_String = logic_uScriptAct_GetGameObjectName_name_52;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_52.Out;
      
      if ( test_0 == true )
      {
         Relay_In_51();
      }
   }
   
   void Relay_SendCustomEvent_53()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_53.SendCustomEvent(logic_uScriptAct_SendCustomEvent_EventName_53, logic_uScriptAct_SendCustomEvent_sendGroup_53, logic_uScriptAct_SendCustomEvent_EventSender_53);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_SendCustomEvent_54()
   {
      {
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_54.SendCustomEvent(logic_uScriptAct_SendCustomEvent_EventName_54, logic_uScriptAct_SendCustomEvent_sendGroup_54, logic_uScriptAct_SendCustomEvent_EventSender_54);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_55()
   {
      local_10_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_55;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_0();
   }
   
   void Relay_OnExitTrigger_55()
   {
      local_10_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_55;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_55()
   {
      local_10_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_55;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_49();
      Relay_In_52();
      Relay_In_44();
   }
   
}
