using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform target; // Transform của nhân vật bạn muốn theo dõi
    public float smoothSpeed = 0.125f; // Tốc độ di chuyển mềm mại của camera
    public Vector3 offset; // Độ lệch của camera so với nhân vật

    private void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
