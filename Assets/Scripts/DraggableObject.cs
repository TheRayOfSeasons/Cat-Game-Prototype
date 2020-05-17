using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler,IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDrag()
    {
        Debug.Log("Drag");
        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.transform.position.z * -1
            )
        );
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Up");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }
}
