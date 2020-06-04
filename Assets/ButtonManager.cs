using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool leftButtonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        leftButtonPressed = true;
        Debug.Log("leftButtonPressed");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        leftButtonPressed = false;
    }
}

