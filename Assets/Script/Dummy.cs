using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dummy : Enemy, IClickable
{
    public void OnMouseDown()
    {
        // Định nghĩa hành vi khi đối tượng Dummy được nhấp chuột ở đây
        Debug.Log("Dummy is clicked!");
        SetTargetSign();
    }
    public void Reset()
    {

    }

}
