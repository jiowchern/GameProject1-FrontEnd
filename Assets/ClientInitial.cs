using UnityEngine;
using System.Collections;

public class ClientInitial : MonoBehaviour
{


    public string NextScene;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Client.Instance.User != null)
	    {
            Application.LoadLevel(NextScene);
	    }
	}
}
