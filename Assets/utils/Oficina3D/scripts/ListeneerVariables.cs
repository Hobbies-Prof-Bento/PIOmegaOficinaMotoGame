using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class ListeneerVariables : MonoBehaviour
{
    
    [SerializeField] private GameObject painelFinishMissions;
    [SerializeField] private GameObject interactiveMenutemplate;
    [SerializeField] private GameObject templateMenu;
    [SerializeField] private GameObject minigame;


    public bool closedFinishMenu = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if((bool)Variables.Application.Get("todasPecasConclued") && !closedFinishMenu){
            closedFinishMenu = true;
            painelFinishMissions.SetActive(true);
        }
        if((bool)painelFinishMissions.activeSelf ||
             (bool)interactiveMenutemplate.activeSelf || 
             (bool)templateMenu.activeSelf || 
             (bool)minigame.activeSelf)
        {
            Variables.Application.Set("openedMenu", true);
             Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Variables.Application.Set("openedMenu", false);
             Cursor.lockState = CursorLockMode.Locked;
        }      
    }
}
