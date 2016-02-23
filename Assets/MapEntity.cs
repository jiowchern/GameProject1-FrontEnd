using UnityEngine;
using System.Collections;



public class MapEntity : MonoBehaviour {
    private RectTransform _Rect;


    void Awake()
    {
        _Rect = GetComponent<RectTransform>();
    }
    // Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetPosition(Vector2 center)
    {
        _Rect.anchoredPosition = center;        
    }

    

    public void SetSize(Vector2 size)
    {
        _Rect.sizeDelta = size;
    }
}
