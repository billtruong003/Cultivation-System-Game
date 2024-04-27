using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventManager : MonoBehaviour
{
    // Định nghĩa một delegate cho sự kiện click chuột
    public delegate void ClickAction(GameObject clickedObject);
    public static event ClickAction OnClicked;

    // Phương thức để gọi sự kiện click
    public static void Click(GameObject clickedObject)
    {
        OnClicked?.Invoke(clickedObject);
    }
}