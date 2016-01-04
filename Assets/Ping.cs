using UnityEngine;
using System.Collections;
using System.Globalization;

public class Ping : MonoBehaviour
{

    public UnityEngine.UI.Text Text;

    private Client _Client;

    // Use this for initialization
	void Start ()
	{

	    _Client = Client.Instance;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (_Client != null)
	    {
            Text.text = _Client.Ping.ToString();
        }
	    
	}
}
