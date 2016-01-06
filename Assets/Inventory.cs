using System;


using UnityEngine;
using System.Collections;


using Regulus.Project.ItIsNotAGame1.Data;

public class Inventory : MonoBehaviour
{
    public GameObject ItemSource;
    public ItemDescription Description;

    protected void _RemoveItem(Guid id)
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
    protected void _Reflush(Item[] items)
    {
        var gameItems = GetComponentsInChildren<GameItem>();
        foreach (var item in items)
        {
            bool any = Bag.UpdateItem(gameItems, item);
            if (any == false)
            {
                _CreateItem(item);
            }
        }
    }
    protected void _AddEvent(Item item)
    {
        _CreateItem(item);
    }
    protected static bool UpdateItem(GameItem[] gameItems, Item item)
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
    protected void _CreateItem(Regulus.Project.ItIsNotAGame1.Data.Item item)
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
}
