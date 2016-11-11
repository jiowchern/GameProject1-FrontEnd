using System;
using System.Linq;

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Regulus.CustomType;

using UnityEditor;

using Regulus.Extension;
using Regulus.Project.ItIsNotAGame1.Data;

using Vector2 = Regulus.CustomType.Vector2;

public class MapExporter : EditorWindow
{
    private UnityEngine.Object _DrawTarget;

    private string _Name;

    [MenuItem("Regulus/ItIsNotAGame1/MapExporter")]
    public static void Open()
    {
        var wnd = EditorWindow.GetWindow(typeof(MapExporter));
        wnd.Show();
    }

    public MapExporter()
    {
        
    }

    void OnGUI()
    {
        EditorGUILayout.BeginVertical();

        _Name = EditorGUILayout.TextField("name", _Name);
        _DrawTarget = EditorGUILayout.ObjectField( _DrawTarget , typeof(DrawMapMesh), true);
        if (GUILayout.Button("Save"))
        {
            var path = EditorUtility.SaveFilePanel("save path", "", "map", "txt");
            var polygons = _Expore();
            if(_DrawTarget != null)
                _Draw(_DrawTarget as DrawMapMesh, polygons);

            _Save(_Name , polygons, path );
        }

        EditorGUILayout.EndVertical();
    }

    private void _Save(string name ,List<Polygon> polygons, string path)
    {
        var towndata = new Regulus.Project.ItIsNotAGame1.Data.TownData
        {
            Name = name, Walls = new WallData[]
            {
                                                
            }
             
        };
        Regulus.Utility.Serialization.Write(towndata, path);        
    }

    private List<Polygon> _Expore()
    {
        var polygons = new List<Polygon>();
        var meshs = GameObject.FindObjectsOfType<MeshCollider>();
        foreach (var meshCollider in meshs)
        {
            var mesh = meshCollider.sharedMesh;
            
            
            var positions = new List<Vector3>();
            foreach (var vector in mesh.vertices)
            {
                var position = _Conversion(meshCollider.transform, vector);
                positions.Add(position);
            }

            var polygon = new Polygon(_To2D(positions));
            polygons.Add(polygon);
        }

        return polygons;
    }

    

    private void _Draw(DrawMapMesh draw_map_mesh, List<Polygon> polygons)
    {
        draw_map_mesh.Set(polygons);
    }

    private Vector2[] _To2D(List<Vector3> positions)
    {        
        
        return (from position in  positions select new Vector2(position.x , position.z)).FindHull().ToArray();
    }

    private Vector3 _Conversion(Transform center, Vector3 vector)
    {
        
        
        var pos = vector;
        pos.Scale(center.lossyScale);

        pos = center.rotation * pos;
        pos += center.position;
        
        return pos;
    }
}
