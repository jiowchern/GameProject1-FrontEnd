using System;

using UnityEngine;
using System.Collections;

using Regulus.Project.ItIsNotAGame1.Data;

public class SkillMake : MonoBehaviour {

    public GameObject MakeObject;

    private Client _Client;

    private IMakeSkill _MakeSkill;

    

    void OnDestroy()
    {
        if (_Client != null)
        {
            _Client.User.MakeControllerProvider.Supply -= _MakeSupply;
            _Client.User.MakeControllerProvider.Unsupply -= _MakeUnsupply;
        }
    }
    

    // Use this for initialization
    void Start () {
        _Client = Client.Instance;

        if (_Client != null)
        {
            _Client.User.MakeControllerProvider.Unsupply += _MakeUnsupply;
            _Client.User.MakeControllerProvider.Supply += _MakeSupply;            
            
        }
    }

    private void _MakeSupply(IMakeSkill obj)
    {
        MakeObject.SetActive(true);
        _MakeSkill = obj;
    }
    private void _MakeUnsupply(IMakeSkill obj)
    {
        MakeObject.SetActive(false);
        _MakeSkill = null;
    }
    // Update is called once per frame
    void Update () {
	
	}
}
