using System;
using UnityEngine;
using System.Linq;
using System.Collections;
using Regulus.CustomType;
using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Extension;
using UnityEditor;

public class EntityExportMark : MonoBehaviour
{
    public string Name;

    public EntityData BuildEntity()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = filter.sharedMesh;
        var vertices = mesh.vertices;

        var points = from vertex in vertices select new Regulus.CustomType.Vector2(vertex.x, vertex.z);

        var data = new EntityData
        {
            Name = Name,
            Mesh = new Polygon(points.FindHull().ToArray())
        };
        return data;
    }


}

