using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine.Events;
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
        SceneChanger._LoadScene(
            new[]
            {
                "login"
            },
            new[]
            {
                Core
            });
    }


    private void _Load(string[] adds, string[] reserveds)
    {
        var removes = new List<string>();
        foreach (var name in SceneChanger._ForeachSceneName())
        {
            if (reserveds.All(reserved => reserved != name))
                removes.Add(name);
        }

        foreach (var remove in removes)
        {
            SceneManager.UnloadScene(remove);
        }



        
        foreach (var add in adds)
        {
            SceneManager.LoadScene(add, LoadSceneMode.Additive);
        }

        StartCoroutine(_SetActiveScene(adds.First()));
    }

    private IEnumerator _SetActiveScene(string first)
    {
        
        Debug.Log(string.Format("active scene is {0}", first));
        var scene = SceneManager.GetSceneByName(first);
        yield return new WaitWhile(() => scene.isLoaded == false);
        var result = SceneManager.SetActiveScene(scene);
        Debug.Log(string.Format("active scene result {0} {1}", result, scene.isLoaded));



    }

    private static void _LoadScene(string[] adds, string[] reserveds)
    {
        var instance = GameObject.FindObjectOfType<SceneChanger>();
        if(instance != null)
            instance._Load(adds , reserveds);

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
        SceneChanger._LoadScene(new[] { realm, "hui" }, new[] { Core });
    }

    
}
