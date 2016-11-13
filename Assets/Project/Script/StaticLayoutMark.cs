using UnityEngine;
using System.Collections.Generic;

using Regulus.Project.ItIsNotAGame1.Data;

public class StaticLayoutMark : MonoBehaviour , IMarkToLayout<StaticLayout>
{

    public EntityLayoutMark Static;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerable<StaticLayout> IMarkToLayout<StaticLayout>.ToLayouts()
    {
        yield return new StaticLayout()
        {
            Owner = Static.GetId()
        };
    }
}
