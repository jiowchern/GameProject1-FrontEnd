using System;


using UnityEngine;
using System.Collections;

using Regulus.Project.ItIsNotAGame1.Data;

public class ItemDescription : MonoBehaviour {

    Client _Client;

    public UnityEngine.UI.Text Name;
    public UnityEngine.UI.Text Effect;
    private IInventoryNotifier _InventoryNotifier;
    private IEquipmentNotifier _EquipmentNotifier;

    private System.Guid _Id ;

    void OnDestroy()
    {
        if (_Client != null)
        {
            
            _Client.User.EquipmentNotifierProvider.Supply -= EquipmentNotifierProvider_Supply;
            _Client.User.InventoryNotifierProvider.Supply -= InventoryNotifierProvider_Supply;
        }
    }

    

    void Start () {
        _Client = Client.Instance;
        if (_Client != null)
        {
            _Client.User.EquipmentNotifierProvider.Supply += EquipmentNotifierProvider_Supply;
            _Client.User.InventoryNotifierProvider.Supply += InventoryNotifierProvider_Supply;
        }
    }

    private void InventoryNotifierProvider_Supply(IInventoryNotifier obj)
    {
        _InventoryNotifier = obj;
    }

    private void EquipmentNotifierProvider_Supply(IEquipmentNotifier obj)
    {
        _EquipmentNotifier = obj;
    }
    void Update ()
    {
	        
	}

    public void Set(Item item)
    {
        _Id = item.Id;
        Name.text = item.Name;
        string effectText = "";

        if(item.Effects != null)
        {
            foreach (var effect in item.Effects)
            {
                effectText += effect.Type.ToString() + ":" + effect.Value;
            }
            Effect.text = effectText;
        }
        else
        {
            Effect.text = "";
        }

    }

    public void Unequip()
    {
        _EquipmentNotifier.Unequip(_Id);
    }
    public void Equip()
    {
        _InventoryNotifier.Equip(_Id);
    }
    public void Discard()
    {
        _InventoryNotifier.Discard(_Id);
    }

    public void Use()
    {
        _InventoryNotifier.Use(_Id);
    }
}
