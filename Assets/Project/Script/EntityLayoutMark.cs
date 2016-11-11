using UnityEngine;
using System.Collections;

using Regulus.Project.ItIsNotAGame1.Data;

using RegulusVector2 = Regulus.CustomType.Vector2;
public class EntityLayoutMark : MonoBehaviour {
    
    public Regulus.Project.ItIsNotAGame1.Data.ENTITY Name;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public RegulusVector2 GetPosition(UnityEngine.Vector3 parent)
    {
        var position = gameObject.transform.position - parent;
        return new RegulusVector2(position.x, position.z);
    }

    public float GetDirection(float parent)
    {
        return gameObject.transform.rotation.eulerAngles.y - parent;
    }

    public EntityLayout BuildLayout()
    {
        throw new System.NotImplementedException();
    }
}
