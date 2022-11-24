using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class itemSlotA : MonoBehaviour, IDropHandler
{

    [SerializeField] public RectTransform item;
    
    public static bool itemMatch; 

    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            
            Debug.Log(GetComponent<RectTransform>().anchoredPosition);
            Debug.Log(item.GetComponent<RectTransform>().anchoredPosition);
            Debug.Log(item.position.y);




            if(Mathf.Abs(eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition.x - item.GetComponent<RectTransform>().anchoredPosition.x)<= 0.5f &&
                Mathf.Abs(eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition.y - item.GetComponent<RectTransform>().anchoredPosition.y)<= 0.5f)
            {                
                Debug.Log("é compatível");
                itemMatch =true;
            }
            else
            {
               Debug.Log("é não compatível");
               itemMatch =false;
            }

        }
    }
}
