using UnityEngine;
using System.Collections;

using Regulus.Utility;

public class TestManger : MonoBehaviour
{

    public TestUpdater[] Updaters;
    public TestDone Done;

    private Regulus.Utility.StageMachine _Machine;

    private int _Count  ;

    public TestManger()
    {
        _Machine = new StageMachine();
    }
    // Use this for initialization
    void Start () {
        Done.gameObject.SetActive(false);
        _Machine.Push( new Regulus.Utility.SimpleStage( _StartUpdater ));
    }

   

    private void _StartUpdater()
    {
        _Count = Updaters.Length;
        foreach (var testUpdater in Updaters)
        {
            testUpdater.DoneEvent +=
                () =>
                {
                    testUpdater.gameObject.SetActive(false);
                    _Count--;
                    if (_Count <= 0)
                    {
                        _ToDone();
                    }
                };
        }
    }

    private void _ToDone()
    {
        _Machine.Push(new Regulus.Utility.SimpleStage(_StartDone));
    }

    private void _StartDone()
    {
        Done.gameObject.SetActive(true);
    }

    // Update is called once per frame
	void Update () {
	
	}
}
