using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDropExample : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{
    public Image data;
    public DragAndDropContainer dragAndDropContainer;
    bool isDragging = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(data.sprite ==null)
        {
            return;
        }

        dragAndDropContainer.gameObject.SetActive(true);
        dragAndDropContainer.image.sprite = data.sprite;

        isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(isDragging == true)
        {
            dragAndDropContainer.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");

        if(isDragging == true)
        {
            if(dragAndDropContainer.image.sprite != null)
            {
                data.sprite = dragAndDropContainer.image.sprite;
            }

            else
            {
                data.sprite = null;
            }
        }

        isDragging = false;
        dragAndDropContainer.image.sprite = null;
        dragAndDropContainer.gameObject.SetActive(false);
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");

        if(dragAndDropContainer.image.sprite != null)
        {
            Sprite tempSprite = data.sprite;

            data.sprite = dragAndDropContainer.image.sprite;

            dragAndDropContainer.image.sprite = tempSprite;
        }

        else
        {
            dragAndDropContainer.image.sprite = null;
        }
    }
}
