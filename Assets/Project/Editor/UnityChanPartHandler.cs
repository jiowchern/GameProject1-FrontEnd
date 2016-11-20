using UnityEngine;
using System.Collections;

using UnityEditor;

public class UnityChanPartHandler : EditorWindow
{
    private Object _CharactorObject;

    [MenuItem("Regulus/ItIsNotAGame1/UnityChanPart")]
    public static void Open()
    {
        var wnd = EditorWindow.GetWindow(typeof(UnityChanPartHandler));
        wnd.Show();
    }

    public void OnGUI()
    {
        EditorGUILayout.BeginVertical();
        _CharactorObject = EditorGUILayout.ObjectField("unity chan", _CharactorObject, typeof (GameObject), true);


        if (GUILayout.Button("Dismantle"))
        {
            _Dismantle(_CharactorObject as GameObject);
        }
        


        EditorGUILayout.EndVertical();
    }

    private void _Dismantle(GameObject charactor)
    {
        
    }
}
