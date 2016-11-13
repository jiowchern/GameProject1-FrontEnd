using System;

using UnityEngine;
using System.Collections;

using Regulus.Utility;

using UnityEngine.SceneManagement;

public class ClientInitial : MonoBehaviour
{
    
	
	// Use this for initialization
	void Start () {		
        SceneChanger.Initial();
	}
	
	// Update is called once per frame
	void Update () 
	{
        
		if (Client.Instance != null && Client.Instance.User != null)
		{
            SceneChanger.ToLogin();
        }
	}
}
