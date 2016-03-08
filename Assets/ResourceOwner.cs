﻿using UnityEngine;
using System.Collections;

using Regulus.Project.ItIsNotAGame1.Data;

public class ResourceOwner : MonoBehaviour {

    public TextAsset EntitySource;
    public TextAsset SkillSource;
    public TextAsset ItemSource;
    public TextAsset ItemFormulaSource;

    public bool LoadOnStart;
    // Use this for initialization
    void Start () {
        if (LoadOnStart)
        {
            Load();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Load()
    {
        Regulus.Project.ItIsNotAGame1.Data.Resource.Instance.Entitys = _ReadEntitys();
        Regulus.Project.ItIsNotAGame1.Data.Resource.Instance.SkillDatas = _ReadSkills();
        Regulus.Project.ItIsNotAGame1.Data.Resource.Instance.Items = _ReadItems();
        Regulus.Project.ItIsNotAGame1.Data.Resource.Instance.Formulas = _ReadItemFormulas();
    }


    private ItemFormula[] _ReadItemFormulas()
    {
        return Regulus.Utility.Serialization.Read<ItemFormula[]>(ItemFormulaSource.bytes);
    }

    private ItemPrototype[] _ReadItems()
    {
        return Regulus.Utility.Serialization.Read<ItemPrototype[]>(ItemSource.bytes);
    }

    private SkillData[] _ReadSkills()
    {
        return Regulus.Utility.Serialization.Read<SkillData[]>(SkillSource.bytes);
    }

    private EntityData[] _ReadEntitys()
    {
        return Regulus.Utility.Serialization.Read<EntityData[]>(EntitySource.bytes);
    }
}