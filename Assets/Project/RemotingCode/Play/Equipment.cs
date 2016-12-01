﻿using System;
using System.Collections.Generic;
using System.Linq;

using Regulus.Project.ItIsNotAGame1.Data;


namespace Regulus.Project.ItIsNotAGame1.Game.Play
{
    public class Equipment : IEquipmentNotifier
    {
        private readonly Entity _Entity;

        private readonly Dictionary<EQUIP_PART, Item> _Items;

        public event Action<Item> AddEvent;
        public event Action<Guid> RemoveEvent;

        private readonly Dictionary<EFFECT_TYPE , ACTOR_STATUS_TYPE> _Skills;
        public Equipment(Entity entity)
        {            
            this._Entity = entity;
            this._Items = new Dictionary<EQUIP_PART, Item>();

            _Skills = new Dictionary<EFFECT_TYPE, ACTOR_STATUS_TYPE>
            {
                {EFFECT_TYPE.SKILL_AXE1, ACTOR_STATUS_TYPE.BATTLE_AXE_IDLE},
                {EFFECT_TYPE.SKILL_SWORD1, ACTOR_STATUS_TYPE.SWORD_IDLE},
                {EFFECT_TYPE.SKILL_CLAYMORE1, ACTOR_STATUS_TYPE.CLAYMORE_IDLE},
                {EFFECT_TYPE.SKILL_MELEE1, ACTOR_STATUS_TYPE.MELEE_IDLE},
            };

        }

        public Item Unequip(EQUIP_PART equip_type)
        {
            Item item;
            _Items.TryGetValue(equip_type, out item);
            if (Item.IsValid(item))
            {
                _Items.Remove(equip_type);
                RemoveEvent(item.Id);
            }
            return item;
        }

        public void Equip(Item item)
        {
            var part = item.GetEquipPart();
            if (_Items.ContainsKey(part) == false)
            {
                _Items.Add(item.GetEquipPart(), item);                
                AddEvent(item);
            }
            else if (part == EQUIP_PART.RIGHT_HAND  && _Items.ContainsKey(EQUIP_PART.LEFT_HAND) == false)
            {
                _Items.Add(EQUIP_PART.LEFT_HAND, item);
                AddEvent(item);
            }
        }


        public Item Find(EQUIP_PART part)
        {
            if (_Items.ContainsKey(part))
                return _Items[part];

            return null;
        }
        public Item[] GetAll()
        {
            return _Items.Values.ToArray();
        }

        public Item Unequip(Guid id)
        {
            var part = (from item in _Items.Values
                        where item.Id == id
                        select item.GetEquipPart()).FirstOrDefault();
            return Unequip(part);
        }

        public void UpdateEffect(float last_delta_time)
        {
            var view = 0.0f;
            var parts = Regulus.Utility.EnumHelper.GetEnums<EQUIP_PART>();

            foreach (var part in parts)
            {
                if (_Items.ContainsKey(part))
                {
                    var item = _Items[part];
                    if (item.UpdateLife(last_delta_time))
                    {
                        foreach (var effect in item.Effects)
                        {
                            if (effect.Type == EFFECT_TYPE.ILLUMINATE_ADD)
                            {
                                view += effect.Value;
                            }
                        }
                        _Items[part] = item;
                    }
                }


            }

            _Entity.SetEquipView(view);
        }

        public ACTOR_STATUS_TYPE GetSkill()
        {
            var item = Find(EQUIP_PART.RIGHT_HAND);
            if (item != null)
            {
                foreach(var effect in item.Effects)
                {
                    foreach (var actorStatusType in _Skills)
                    {
                        if (actorStatusType.Key == effect.Type)
                        {
                            return actorStatusType.Value;
                        }
                    }

                }
            }
            return ACTOR_STATUS_TYPE.MELEE_IDLE;
        }
    }
}