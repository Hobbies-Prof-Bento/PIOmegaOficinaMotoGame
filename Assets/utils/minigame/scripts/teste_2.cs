using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class teste_2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,IEndDragHandler, IDragHandler, IDropHandler
{

    /* [SerializeField] */
    /* private Transform test2Place;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool locked; */

    [SerializeField] private Canvas canvas;

    private RectTransform recTransform;
    private CanvasGroup canvasGroup;

    private void Awake(){
        recTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    // Start is called before the first frame update
   /*  void Start()
    {
        initialPosition = transform.position;
    } */

    

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        recTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");        
    }


    // Update is called once per frame
   /*  void Update()
    {
        if(!locked){
            if(Input.GetMouseButtonDown(0)){
                transform.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            }
        }
        if(Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    }
                    break;

                case TouchPhase.Ended:
                    if(Mathf.Abs(transform.position.x - test2Place.position.x)<= 0.5f &&
                       Mathf.Abs(transform.position.y - test2Place.position.y)<= 0.5f)
                    {
                        transform.position = new Vector2(test2Place.position.x, test2Place.position.y);
                        locked = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;
            }
        }
    } */
}
