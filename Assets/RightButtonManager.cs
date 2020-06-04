using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class RightButtonManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool rightButtonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        rightButtonPressed = true;
        Debug.Log("rightButtonPressed");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rightButtonPressed = false;
    }
}