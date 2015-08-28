using System;
using UnityEngine;
using System.Linq;
using System.Collections;
using Regulus.CustomType;
using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Extension;


public class EntityExportMark : MonoBehaviour
{
    public Regulus.Project.ItIsNotAGame1.Data.ENTITY Name;

    public EntityData BuildEntity()
    {
        var filter = GetComponent<MeshFilter>();
        var sharedMesh = filter.sharedMesh;
        var sourceMesh = GameObject.Instantiate(sharedMesh);


        var vertices = sourceMesh.vertices;
        var angle = Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.up);
        for (var i = 0; i < vertices.Length; i++)
        {
            var vertex = vertices[i];
            vertex.x = vertex.x*transform.localScale.x;
            vertex.y = vertex.y*transform.localScale.y;
            vertex.z = vertex.z*transform.localScale.z;

            vertex = angle * vertex;            

            vertices[i] = vertex;
        }
        

        var points = from vertex in vertices select new Regulus.CustomType.Vector2(vertex.x, vertex.z);

        var data = new EntityData
        {
            Name = Name,
            Mesh = new Polygon(points.FindHull().ToArray())
        };
        return data;
    }


}

