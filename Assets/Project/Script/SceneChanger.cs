using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static  SceneChanger Instance { get { return Object.FindObjectOfType<SceneChanger>();  } }

    public static Client.MODE Mode;
    private const string Core = "core";
    public void Initial(Client.MODE remoting)
    {
        Mode = remoting;
        SceneManager.LoadScene(Core, LoadSceneMode.Additive);    
    }

    public void ToQuit()
    {
        Application.Quit();
    }
    public void ToStart()
    {
        SceneManager.LoadScene("start", LoadSceneMode.Single);
    }

    public void ToLogin()
    {
        

        _LoadScene( 
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
        foreach (var name in _ForeachSceneName())
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
        var instance = Instance;
        if(instance != null)
            instance.StartCoroutine(_SetActiveScene(adds.First()));
    }

    private IEnumerator _SetActiveScene(string first)
    {
        
        Debug.Log(string.Format("active scene is {0}", first));
        var scene = SceneManager.GetSceneByName(first);
        yield return new WaitWhile(() => scene.isLoaded == false);
        var result = SceneManager.SetActiveScene(scene);
        Debug.Log(string.Format("active scene result {0} {1}", result, scene.isLoaded));



    }

    private void _LoadScene(string[] adds, string[] reserveds)
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
    

    public void ToRealm(string realm)
    {
        SceneChanger.Instance._LoadScene(new[] { realm, "hui" }, new[] { Core });
    }


    public void ToCredits()
    {
        SceneChanger.Instance._LoadScene(new[] { "credits" }, new[] { Core });
    }
}
