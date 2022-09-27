using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escaper : MonoBehaviour
{
    public GameObject desc;
    public GameObject disp;
    public GameObject downBtn;
    public GameObject upBtn;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if(desc.activeSelf == true && Input.GetButtonDown("Jump")){
            upBtn.SetActive(false);
            downBtn.SetActive(true);
            player.GetComponent<PlayerMovement>().canMove=true;
            disp.SetActive(false);
            desc.SetActive(false);
        }
    }
}
