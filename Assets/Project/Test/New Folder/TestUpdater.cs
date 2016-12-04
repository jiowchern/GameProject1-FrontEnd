using System;

using UnityEngine;
using System.Collections;

public class TestUpdater : MonoBehaviour {
    private float _TimeUp;

    public event Action DoneEvent;



    // Use this for initialization
	void Start ()
	{
	    _TimeUp = Regulus.Utility.Random.Instance.NextFloat(1, 10);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _TimeUp -= UnityEngine.Time.deltaTime;
	    if (_TimeUp <= 0)
	    {
	        DoneEvent();
	    }
	}
}
