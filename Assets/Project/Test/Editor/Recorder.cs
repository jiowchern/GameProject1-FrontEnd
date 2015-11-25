using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


using UnityEditor;
using UnityEditor.Animations;

public class Recorder : EditorWindow {
    [MenuItem("Regulus/Test/Recorder")]
    public static void Open()
    {
        var wnd = EditorWindow.GetWindow(typeof(Recorder));
        wnd.Show();
    }

    public Recorder()
    {
        _State = "";
    }

    Object _Ani;

    private string _Layer;

    private string _State;

    private float _Interval;

    private Object _Drawer;

    public void OnGUI()
    {
        EditorGUILayout.BeginVertical();

        
        _Ani = EditorGUILayout.ObjectField("Animator", _Ani, typeof(Animator) , true);
        _Layer = EditorGUILayout.TextField("Layer", _Layer);
        _State = EditorGUILayout.TextField("State", _State);
        _Interval = EditorGUILayout.FloatField("Interval", _Interval);
        _Drawer = EditorGUILayout.ObjectField("Drawer", _Drawer, typeof(DeterminationDrawer), true);

        if (GUILayout.Button("Go"))
        {
            _Catche();
        }
        EditorGUILayout.EndVertical();
    }

    private void _Catche()
    {
        var anim = _Ani as Animator;
        var ac = anim.runtimeAnimatorController as UnityEditor.Animations.AnimatorController;
        if(ac != null)
        {
            var state = _FindLayer(ac, _Layer);
            var clip = _FindClips(state , _State);
            Vector2[] points = _FindPoints(clip, _Interval);
            var drawer = _Drawer as DeterminationDrawer;
            drawer.Second = clip.length;
            _Draw(points);
        }
        
    }

    private void _Draw(Vector2[] points)
    {
        var drawer = _Drawer as DeterminationDrawer;
        List< Vector2 > left = new List<Vector2>();
        List<Vector2> right = new List<Vector2>();
        for (int i = 0; i < points.Length - 1; i+= 2)
        {
            left.Add(points[i]);
            right.Add(points[i+1]);
        }

        drawer.Left = left.ToArray();
        drawer.Right = right.ToArray();
    }


    
    
    private Vector2[] _FindPoints( AnimationClip clip, float interval)
    {
        var anim = _Ani as Animator;
        var go = anim.gameObject;
        var marks = go.GetComponentsInChildren<DeterminationExportMark>();
        var markLeft = (from m in marks where m.Part == DeterminationExportMark.PART.LEFT select m).Single();
        var markRight = (from m in marks where m.Part == DeterminationExportMark.PART.RIGHT select m).Single();
        List < Vector2 > points = new List<Vector2>();
        for (var i = 0.0f; i < clip.length; i+= interval)
        {
            clip.SampleAnimation(go, i);            
            Debug.LogFormat("mark {0} , Position {1}", markLeft.GetInstanceID(), markLeft.Position);
            points.Add(markLeft.Position);

            Debug.LogFormat("mark {0} , Position {1}", markRight.GetInstanceID(), markRight.Position);
            points.Add(markRight.Position);

        }

        clip.SampleAnimation(go, clip.length);
        if(markLeft.Enable)
        {
            Debug.LogFormat("mark {0} , Position {1}", markLeft.GetInstanceID(), markLeft.Position);
            points.Add(markLeft.Position);
        }

        if(markRight.Enable)
        {
            Debug.LogFormat("mark {0} , Position {1}", markRight.GetInstanceID(), markRight.Position);
            points.Add(markRight.Position);
        }
            

        return points.ToArray();
    }

    private AnimationClip _FindClips(AnimatorStateMachine state, string state_name)
    {
        return
            (from child in state.states where child.state.name == state_name select child.state.motion as AnimationClip)
                .SingleOrDefault();
    }

    private UnityEditor.Animations.AnimatorStateMachine _FindLayer(AnimatorController animator_controller, string layer)
    {
        return (from l in animator_controller.layers where l.name == layer select l.stateMachine).First();
    }

    
    
}
