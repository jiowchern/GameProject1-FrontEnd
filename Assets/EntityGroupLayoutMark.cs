using UnityEngine;
using System.Collections.Generic;

using Regulus.Project.ItIsNotAGame1.Data;

public class EntityGroupLayoutMark : MonoBehaviour
{
    public string Id;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerable<EntityLayout> GetMarks()
    {
        var marks = gameObject.GetComponentsInChildren<EntityExportMark>();
        foreach (var entityExportMark in marks)
        {
            var el = new EntityLayout();
            el.Type = entityExportMark.Name;
            el.Position = entityExportMark.GetPosition(gameObject.transform.position); 
            el.Direction = entityExportMark.GetDirection(gameObject.transform.rotation.eulerAngles.y);
            yield return el;
        }
    }
}
