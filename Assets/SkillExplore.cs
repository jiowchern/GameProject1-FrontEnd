using System;

using UnityEngine;
using System.Collections;
using System.Linq;

using Regulus.Project.ItIsNotAGame1.Data;

public class SkillExplore : MonoBehaviour {
    private Client _Client;

    public UnityEngine.UI.Image Image;

    public UnityEngine.UI.Button Button;
    private ISkillController _SkillController;

    // Use this for initialization
	void Start () {
        _Disable();
	    _Client = Client.Instance;
        if(_Client != null)
        {
            _Client.User.SkillControllerProvider.Supply += _Supply;
            _Client.User.SkillControllerProvider.Unsupply += _Unsupply;
        }

        
    }

    private void _Disable()
    {
        Image.enabled = false;
        Button.enabled = false;
        _SkillController = null;
    }

    void OnDestroy()
    {
        if (_Client != null)
        {
            _Client.User.SkillControllerProvider.Supply -= _Supply;
            _Client.User.SkillControllerProvider.Unsupply -= _Unsupply;
        }
    }

    private void _Unsupply(ISkillController obj)
    {
        _Disable();        
        
    }

    private void _Supply(ISkillController obj)
    {
        _Enable(obj);
    }

    private void _Enable(ISkillController skill_controller)
    {
        Button.enabled = true;
        Image.enabled = true;
        _SkillController = skill_controller;
    }

    // Update is called once per frame
	void Update ()
    {
        if(_SkillController != null)
	        if (Input.GetKeyUp(KeyCode.E))
	        {
	            Explore();
	        }
	}

    public void Explore()
    {
        if (_Client != null)
        {
            var entity = GameObject.FindObjectsOfType<Entity>().FirstOrDefault(e => e.Id == EntityController.MainEntityId);
            if (entity != null)
            {
                var id= entity.GetExploreTarget();
                if(id != Guid.Empty)
                    _SkillController.Explore(id);
            }
                
        }
        
    }
}
