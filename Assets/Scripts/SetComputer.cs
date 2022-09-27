using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetComputer : MonoBehaviour
{
    public Transform target; 
    private float xPos;
    // Update is called once per frame
    void FixedUpdate()
    {   
        xPos = target.position.x;
        transform.position = new Vector3(xPos,transform.position.y,transform.position.z);        
    }
}
