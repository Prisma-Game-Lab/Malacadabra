using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class RotateHand : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
    public event Action<Quaternion> AngleHandRotation;
    Quaternion dragStartRotation;
    Quaternion dragStartInverseRotation;

    private void Awake()
    {
        AngleHandRotation += (rotation) => transform.localRotation = rotation;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        dragStartRotation = transform.localRotation;
        Vector3 genericHand;
        if (DragGenericHand(eventData, out genericHand))
        {
            dragStartInverseRotation = Quaternion.Inverse(Quaternion.LookRotation(genericHand - transform.position, Vector3.forward));
        }
    
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 genericHand;
        if (DragGenericHand(eventData, out genericHand))
        {
            Quaternion currentDragAngle = Quaternion.LookRotation(genericHand - transform.position, Vector3.forward);
            if (AngleHandRotation != null)
            {
                AngleHandRotation(currentDragAngle * dragStartInverseRotation * dragStartRotation);
            }
        }
    }
    private bool DragGenericHand(PointerEventData eventData, out Vector3 genericHand)
    {
        return RectTransformUtility.ScreenPointToWorldPointInRectangle(GetComponent<RectTransform>(),eventData.position,eventData.pressEventCamera,out genericHand);
    }
    
}



