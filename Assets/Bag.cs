using System;

using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1;
using System.Linq;

using Regulus.Project.ItIsNotAGame1.Data;

using UnityEngine.UI;

public class Bag : Inventory
{

    
    private Client _Client;
    private Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier _InventoryNotifier;

    // Use this for initialization
    void Start () {
        _Client = Client.Instance;
        if(_Client != null)
        {
            _Client.User.InventoryNotifierProvider.Supply += InventoryNotifierProvider_Supply;
        }
	}

    void OnDestroy()
    {
        if (_Client != null)
        {
            if (_InventoryNotifier != null)
            {
                _InventoryNotifier.AllItemEvent -= _InventoryNotifier_AllItemEvent;
                _InventoryNotifier.RemoveEvent -= _RemoveItem;
                _InventoryNotifier.AddEvent -= _AddEvent;
            }
            _Client.User.InventoryNotifierProvider.Supply -= InventoryNotifierProvider_Supply;
        }
    }

    

    private void InventoryNotifierProvider_Supply(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier obj)
    {
        _InventoryNotifier = obj;
        _InventoryNotifier.AllItemEvent += _InventoryNotifier_AllItemEvent;
        _InventoryNotifier.RemoveEvent += _RemoveItem;
        _InventoryNotifier.AddEvent += _AddEvent;
        _InventoryNotifier.Query();
    }

   

    void OnEnable()
    {
        if(_InventoryNotifier != null)
            _InventoryNotifier.Query();
    }


    private void _InventoryNotifier_AllItemEvent(Regulus.Project.ItIsNotAGame1.Data.Item[] items)
    {
        _Reflush(items);
    }

    

    

    

    

    // Update is called once per frame
    void Update () {
	
	}
}
