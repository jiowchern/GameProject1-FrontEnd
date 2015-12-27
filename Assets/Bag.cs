using System;

using UnityEngine;
using System.Collections;
using Regulus.Project.ItIsNotAGame1;
using System.Linq;

using Regulus.Project.ItIsNotAGame1.Data;

using UnityEngine.UI;

public class Bag : MonoBehaviour {

    public GameObject ItemSource;
    private Client _Client;
    private Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier _InventoryNotifier;

    public ItemDescription Description;

    

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

    private void _RemoveItem(Guid id)
    {
        var gameItems = GetComponentsInChildren<GameItem>();
        foreach (var item in gameItems)
        {
            if (item.Id == id)
            {
                GameObject.DestroyObject(item.gameObject);
            }
        }
    }

    void OnEnable()
    {
        if(_InventoryNotifier != null)
            _InventoryNotifier.Query();
    }


    private void _InventoryNotifier_AllItemEvent(Regulus.Project.ItIsNotAGame1.Data.Item[] items)
    {
        var gameItems = GetComponentsInChildren<GameItem>();
        foreach(var item in items)
        {
            bool any = Bag.UpdateItem(gameItems, item);                        
            if(any == false)
                _CreateItem(item);
        }
    }

    private void _AddEvent(Item item)
    {
        _CreateItem(item);
    }

    private static bool UpdateItem(GameItem[] gameItems, Item item)
    {
        foreach (var gi in gameItems)
        {
            if (gi.Id == item.Id)
            {
                gi.Set(item);
                return true;
            }
        }
        return false;
    }

    private void _CreateItem(Regulus.Project.ItIsNotAGame1.Data.Item item)
    {
        var slot = GameObject.Instantiate(ItemSource);
                
        var rectTransform = slot.GetComponent<RectTransform>();
        rectTransform.SetParent(transform);
        slot.GetComponent<GameItem>().Set(item);
        var button = slot.GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(
            () =>
            {
                Description.Set(item);
            });
    }

    // Update is called once per frame
    void Update () {
	
	}
}
