using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDisplay : MonoBehaviour
{
    public GameObject scrDisp;
    public GameObject player;
    public GameObject upBtn;
    public GameObject downBtn;
    public Sprite firstMessage;
    public Sprite firstPointOneMessage;
    public Sprite thirdMessage;
    public Sprite thirdPointOneMessage;
    public Sprite secondMessage;
    public Sprite secondPointOneMessage;
    public Sprite fourthMessage;
    public Sprite fourPointOneMessage;
    public Sprite fifthMessage;
    public Sprite fivePointOneMessage;
    public Sprite sixthMessage;
    public Sprite sixPointOneMessage;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            upBtn.SetActive(true);
            downBtn.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            upBtn.SetActive(false);
            downBtn.SetActive(true);
        }
        if (gameObject.activeSelf == true){
            player.GetComponent<PlayerMovement>().canMove=false;
            scrDisp.SetActive(true);
            //first one
            if (upBtn.activeSelf==false && player.GetComponent<Collections>().score==1){
                scrDisp.GetComponent<SpriteRenderer>().sprite = firstMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==1){
                scrDisp.GetComponent<SpriteRenderer>().sprite = firstPointOneMessage; 
            }
            //second one
            if (upBtn.activeSelf==false && player.GetComponent<Collections>().score==2){
                scrDisp.GetComponent<SpriteRenderer>().sprite = secondMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==2){
                scrDisp.GetComponent<SpriteRenderer>().sprite = secondPointOneMessage; 
            }
            //third one
            if (upBtn.activeSelf==false &&player.GetComponent<Collections>().score==3){
                scrDisp.GetComponent<SpriteRenderer>().sprite = thirdMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==3){
                scrDisp.GetComponent<SpriteRenderer>().sprite = thirdPointOneMessage; 
            }
            //fourth one
            if (upBtn.activeSelf==false &&player.GetComponent<Collections>().score==4){
                scrDisp.GetComponent<SpriteRenderer>().sprite = fourthMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==4){
                scrDisp.GetComponent<SpriteRenderer>().sprite = fourPointOneMessage; 
            }
            //fifth one
            if (upBtn.activeSelf==false &&player.GetComponent<Collections>().score==5){
                scrDisp.GetComponent<SpriteRenderer>().sprite = fifthMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==5){
                scrDisp.GetComponent<SpriteRenderer>().sprite = fivePointOneMessage; 
            }
            //sixth one
            if (upBtn.activeSelf==false &&player.GetComponent<Collections>().score==6){
                scrDisp.GetComponent<SpriteRenderer>().sprite = sixthMessage;
            }
            if (downBtn.activeSelf==false && player.GetComponent<Collections>().score==6){
                scrDisp.GetComponent<SpriteRenderer>().sprite = sixPointOneMessage; 
            }
        }
    }
}
