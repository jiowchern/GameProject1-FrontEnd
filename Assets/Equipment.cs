using System;


using UnityEngine;
using System.Collections;


using Regulus.Project.ItIsNotAGame1.Data;

public class Equipment : Inventory {

    private Client _Client;

    private IEquipmentNotifier _Notifier;
    void OnDestroy()
    {
        if (_Client != null)
        {
            if (_Notifier != null)
            {
                _Notifier.FlushEvent -= _Reflush;
                _Notifier.RemoveEvent -= _RemoveItem;
                _Notifier.AddEvent -= _AddEvent;
            }
            _Client.User.EquipmentNotifierProvider.Supply -= EquipmentNotifierProviderOnSupply;
        }
    }
    // Use this for initialization
    void Start () {
        _Client = Client.Instance;
        if (_Client != null)
        {
            _Client.User.EquipmentNotifierProvider.Supply += EquipmentNotifierProviderOnSupply;
        }
    }

    private void EquipmentNotifierProviderOnSupply(IEquipmentNotifier equipment_notifier)
    {
        _Notifier = equipment_notifier;
        
        _Notifier.FlushEvent += _Reflush;
        _Notifier.RemoveEvent += _RemoveItem;
        _Notifier.AddEvent += _AddEvent;
        _Notifier.Query();
    }

    // Update is called once per frame
	void Update () {
	
	}
}
