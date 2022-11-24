using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class miniGameControl : MonoBehaviour
{       
    [SerializeField] private GameObject minigame;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject loseText;       

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        loseText.SetActive(false);            
    }

    // Update is called once per frame
    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }
 
    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);
        
        //Do the action after the delay time has finished.
    }
    public void testar(){
        if(itemSlotA.itemMatch &&
            itemSlotB.itemMatch &&
            itemSlotC.itemMatch &&
            itemSlotD.itemMatch &&
            itemSlotE.itemMatch)
        {
            winText.SetActive(true);   
            //DoDelayAction(5.0f);
            winText.SetActive(false); 
            minigame.SetActive(false); 
            Variables.Application.Set("minigameConclued", true);         
        }
        else{
            loseText.SetActive(true);  
            //DoDelayAction(5.0f);             
            //loseText.SetActive(false);   
        }
    }
}
