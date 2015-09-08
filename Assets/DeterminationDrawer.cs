using UnityEngine;
using System.Collections;
using System.Linq;


using Regulus.Utility;

public class DeterminationDrawer : MonoBehaviour {
    public Vector2[] Left;

    public Vector2[] Right;

    public float Second;

    private Regulus.Utility.TimeCounter _TimeCounter;

    private float _LastPart;

    // Use this for initialization
	void Start () {
        _TimeCounter = new TimeCounter();
        _TimeCounter.Reset();
	    _LastPart = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float part = _TimeCounter.Second / Second;

        if (Left != null )
            _Draw(Left , _LastPart ,part);
        if (Right != null)
            _Draw(Right , _LastPart  , part);

        _LastPart = part;
        if (_TimeCounter.Second > Second)
            _TimeCounter.Reset();
    }

    private void _Draw(Vector2[] points , float part_begin , float part_end)
    {
        var length = points.Length;
        for (int i = 0; i < length - 1; i++)
        {
            int pb = (int)(((float)length) * part_begin);
            int pe = (int)(((float)length) * part_end);
            _Draw(points , i , i >= pb && i <= pe ? Color.blue : Color.white);            
        }
        
    }

    private void _Draw(Vector2[] points, int i , Color color)
    {
        var p1 = new UnityEngine.Vector3(points[i].x, 0, points[i].y);
        var p2 = new UnityEngine.Vector3(points[i + 1].x, 0, points[i + 1].y);
        
        Debug.DrawLine(transform.position + p1, transform.position + p2, color);
    }
}
