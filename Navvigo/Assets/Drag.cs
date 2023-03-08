using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform dragRectTransform;
    public bool opening = false;
    public bool is_drag = false;

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += new Vector2(0, eventData.delta.y/(Screen.height/650));
        is_drag = true;
        if (dragRectTransform.anchoredPosition.y > 0)
        {
            dragRectTransform.anchoredPosition = new Vector2(0,0);
            is_drag = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (dragRectTransform.anchoredPosition.y < -20f)
        {
            opening = false;
            is_drag = false;
        }
        else
        {
            opening = true;
            is_drag = false;
        }
    }

    public void OpenDetailPage()
    {
        opening = true;
    }

    private void Update()
    {
        if (opening)
        {
            if(!is_drag)
                if (dragRectTransform.anchoredPosition.y < 0)
                    dragRectTransform.anchoredPosition += new Vector2(0, 5);
        }
        else
        {
            if (!is_drag)
                if (dragRectTransform.anchoredPosition.y > -598)
                    dragRectTransform.anchoredPosition += new Vector2(0, -5);
        }
    }
}



