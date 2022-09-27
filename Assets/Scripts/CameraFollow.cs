using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float offset;
 
    // Update is called once per frame
    void FixedUpdate()
    {
        float desiredPosition = target.position.x + offset;
        float yPos = transform.position.y;
        transform.position = new Vector3(desiredPosition,yPos,-2);
    }
}
