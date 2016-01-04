using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


using UnityEditor;
using UnityEditor.Animations;

public class Recorder : EditorWindow {
    [MenuItem("Regulus/ItIsNotAGame1/Recorder")]
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

    private string _Layer = "Base Layer";

    private string _State;

    private float _Interval = 1.0f / 30.0f;

    private Object _Drawer;

    private float _BeginTime;

    private float _EndTime;

    private Object _Skill;

    public void OnGUI()
    {
        EditorGUILayout.BeginVertical();

        var pervAni = _Ani;
        _Ani = EditorGUILayout.ObjectField("Animator", _Ani, typeof(Animator) , true);
        _Layer = EditorGUILayout.TextField("Layer", _Layer);
        _State = EditorGUILayout.TextField("State", _State);
        _BeginTime = EditorGUILayout.FloatField("BeginTime", _BeginTime);
        _EndTime = EditorGUILayout.FloatField("EndTime", _EndTime);
        _Interval = EditorGUILayout.FloatField("Interval", _Interval);
        _Drawer = EditorGUILayout.ObjectField("Drawer", _Drawer, typeof(DeterminationDrawer), true);
        _Skill = EditorGUILayout.ObjectField("Skill", _Skill, typeof(SkillExportMark), true);


        if (GUILayout.Button("Go"))
        {
            _Catche();
        }
        EditorGUILayout.EndVertical();

        if (_Ani != pervAni)
        {

            _UpdateTime();
        }
    }

    private void _UpdateTime()
    {
        if (_Ani == null)
            return;
        var anim = _Ani as Animator;
        
        var ac = anim.runtimeAnimatorController as UnityEditor.Animations.AnimatorController;
        var infos = anim.GetCurrentAnimatorClipInfo(0);
        if (ac == null)
        {
            return;
        }
        var state = _FindLayer(ac, _Layer);
        if (state == null)
            return;
        var clip = _FindClips(state, _State);

        if (clip == null)
            return;
        _BeginTime = 0;
        _EndTime = clip.length;
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
            
            _Record(points , clip.length , _BeginTime , _EndTime);

            
            
        }
        
    }

    private void _Record(Vector2[] points, float length, float begin_time, float end_time)
    {
        
        List<Vector2> left = new List<Vector2>();
        List<Vector2> right = new List<Vector2>();
        for (int i = 0; i < points.Length - 1; i += 2)
        {
            left.Add(points[i]);
            right.Add(points[i + 1]);
        }
        var drawer = _Drawer as DeterminationDrawer;
        if (drawer != null)
        {
            drawer.Left = left.ToArray();
            drawer.Right = right.ToArray();
            drawer.Total = length;
            drawer.Begin = begin_time;
            drawer.End = end_time;
        }

        var skillExportMark = _Skill as SkillExportMark;
        if (skillExportMark != null)
        {
            skillExportMark.Data.Lefts = (from l in left select new Regulus.CustomType.Vector2(l.x , l.y)).ToArray();
            skillExportMark.Data.Rights = (from r in right select new Regulus.CustomType.Vector2(r.x, r.y)).ToArray();
            skillExportMark.Data.Total = length;
            skillExportMark.Data.Begin = begin_time;
            skillExportMark.Data.End = end_time;

        }

    }

    private void _Record(Vector2[] points)
    {
        
    }


    
    
    private Vector2[] _FindPoints( AnimationClip clip, float interval)
    {
        var anim = _Ani as Animator;
        var go = anim.gameObject;
        var position = new Vector2(go.transform.position.x , go.transform.position.z);
        var marks = go.GetComponentsInChildren<DeterminationExportMark>();
        var markLeft = (from m in marks where m.Part == DeterminationExportMark.PART.LEFT select m).Single();
        var markRight = (from m in marks where m.Part == DeterminationExportMark.PART.RIGHT select m).Single();
        List < Vector2 > points = new List<Vector2>();
        for (var i = _BeginTime ; i < _EndTime; i+= interval)
        {
            clip.SampleAnimation(go, i);            
            Debug.LogFormat("mark {0} , Position {1}", markLeft.GetInstanceID(), markLeft.Position);
            points.Add(markLeft.Position - position);

            Debug.LogFormat("mark {0} , Position {1}", markRight.GetInstanceID(), markRight.Position);
            points.Add(markRight.Position - position);

        }

        clip.SampleAnimation(go, clip.length);
        if(markLeft.Enable)
        {
            Debug.LogFormat("mark {0} , Position {1}", markLeft.GetInstanceID(), markLeft.Position);
            points.Add(markLeft.Position - position);
        }

        if(markRight.Enable)
        {
            Debug.LogFormat("mark {0} , Position {1}", markRight.GetInstanceID(), markRight.Position);
            points.Add(markRight.Position - position);
        }
            

        return points.ToArray();
    }

    private AnimationClip _FindClips(AnimatorStateMachine state, string state_name)
    {
        foreach (var child in state.states)
        {
            Debug.Log("Clip name " + child.state.name);
            if (child.state.name == state_name)
            {
                return child.state.motion as AnimationClip;
            }
        }

        return null;
        return
            (from child in state.states where child.state.name == state_name select child.state.motion as AnimationClip)
                .SingleOrDefault();
    }

    private UnityEditor.Animations.AnimatorStateMachine _FindLayer(AnimatorController animator_controller, string layer)
    {
        foreach (var l in animator_controller.layers)
        {
            Debug.Log("Find Layer "+ l.name);
            if (l.name == layer)
                return l.stateMachine;            
        }
        return null;

        //return (from l in animator_controller.layers where l.name == layer select l.stateMachine).First();
    }

    
    
}
