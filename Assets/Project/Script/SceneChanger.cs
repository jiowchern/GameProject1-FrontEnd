using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private const string Core = "core";
    public static void Initial()
    {
        SceneManager.LoadScene("core" , LoadSceneMode.Additive);    
    }

    public static void ToLogin()
    {
        _Load(
            new[]
            {
                "login"
            },
            new[]
            {
                Core
            });
    }

    private static void _Load(string[] adds, string[] reserveds)
    {
        var removes = new List<string>();
        foreach (var name in SceneChanger._ForeachSceneName())
        {
            if(reserveds.All(reserved => reserved != name))
                removes.Add(name);
        }

        foreach (var remove in removes)
        {
            SceneManager.UnloadScene(remove);
        }

        foreach (var add in adds)
        {
            SceneManager.LoadScene(add , LoadSceneMode.Additive);
        }

        var scene = SceneManager.CreateScene("game");
        SceneManager.SetActiveScene(scene);

    }

    static IEnumerable<string> _ForeachSceneName()
    {
        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            var scene = SceneManager.GetSceneAt(i);
            yield return scene.name;
        }
    }
    

    public static void ToRealm(string realm)
    {
        _Load(new[] { realm, "hui" }, new[] { Core });
    }

    
}
