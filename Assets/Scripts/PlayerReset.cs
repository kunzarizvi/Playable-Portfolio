using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y < -2.83){
            playerTransform.position = originalPosition;    
        }
        
    }
}
