﻿using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Utility;
using UnityEditor;

public class EntityExportWindow : EditorWindow
{

    [MenuItem("Regulus/ItIsNotAGame1/ExportEntity")]
    static public void ExportFromScene()
    {
        var marks = GameObject.FindObjectsOfType<EntityExportMark>();        
        var entitys = (from mark in marks select mark.BuildEntity()).ToArray();

        var path = EditorUtility.SaveFilePanel("select", "", "entitys.txt", "txt");
        Serialization.Write(entitys , path);
    }
}