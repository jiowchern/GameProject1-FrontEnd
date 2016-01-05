using System;
using System.Linq;


using UnityEngine;
using System.Collections;


using Regulus.Project.ItIsNotAGame1.Data;

public class UIItemFormula : MonoBehaviour
{

    public UnityEngine.UI.Text Name;
    public UnityEngine.UI.Text Item;

    public UnityEngine.UI.Text[] MaterialNames;
    public UnityEngine.UI.Text[] MaterialAmountTexts;
    public UnityEngine.UI.Slider[] MaterialAmounts;

    public Action<string, int[]> MakeEvent;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    for(int i = 0; i < MaterialNames.Length; i++)
	    {
            MaterialAmountTexts[i].text = ((int)MaterialAmounts[i].value).ToString();
	    }
	}

    public void Set(ItemFormulaLite formula_lite)
    {
        
        Name.text = formula_lite.Name;
        Item.text = formula_lite.Item;
        int i = 0;
        for (; i < formula_lite.NeedItems.Length ; i++)
        {
            var item = formula_lite.NeedItems[i];
            MaterialNames[i].text = item.Item;            
            MaterialAmounts[i].minValue = item.Min;
            MaterialAmounts[i].maxValue = 10;
            MaterialAmountTexts[i].text = item.Min.ToString();
        }
        for(; i < MaterialNames.Length ; i++)
        {
            MaterialNames[i].enabled = false;
            MaterialAmounts[i].enabled = false;            
            MaterialAmountTexts[i].enabled = false;
        }
    }

    public void Make()
    {
        var amounts = (from amount in MaterialAmounts where amount.enabled select (int)amount.value).ToArray();
        MakeEvent(Name.text , amounts);
    }
}
