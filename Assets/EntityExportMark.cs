using System;
using UnityEngine;
using System.Linq;
using System.Collections;
using Regulus.CustomType;
using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Extension;

using RegulusVector2 = Regulus.CustomType.Vector2;

public class EntityExportMark : MonoBehaviour
{
    public Regulus.Project.ItIsNotAGame1.Data.ENTITY Name;

    public bool CollisionRotation;
    public GameObject Body;
    public EntityData BuildEntity()
    {
        
        var filter = Body.GetComponent<MeshFilter>();
        var sharedMesh = filter.sharedMesh;
        var sourceMesh = GameObject.Instantiate(sharedMesh);


        var vertices = sourceMesh.vertices;
        var angle = Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.up);
        for (var i = 0; i < vertices.Length; i++)
        {
            
            var vertex = vertices[i];
            
            vertex.x = vertex.x* Body.transform.lossyScale.x;
            vertex.y = vertex.y* Body.transform.lossyScale.y;
            vertex.z = vertex.z* Body.transform.lossyScale.z;

            vertex = angle * vertex;            

            vertices[i] = vertex;
        }

        var points = from vertex in vertices select new Regulus.CustomType.Vector2(vertex.x, vertex.z);

        var data = new EntityData
        {
            Name = Name,
            Mesh = new Polygon(points.FindHull().ToArray()),
            CollisionRotation = CollisionRotation
        };
        return data;
    }

    public RegulusVector2 GetPosition(UnityEngine.Vector3 parent)
    {
        var position = gameObject.transform.position - parent;
        return new RegulusVector2(position.x , position.z);
    }

    public float GetDirection(float parent)
    {
        return gameObject.transform.rotation.eulerAngles.y - parent;
    }
}

