using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded = true;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal")*moveSpeed;
        if (Input.GetButtonDown("Jump") && rb.velocity.y==0){
            rb.AddForce(Vector2.up * 700f);
        }
        if(Mathf.Abs(dirX)>0 && rb.velocity.y==0){
            anim.SetBool("IsRunning",true);
        }
        else{
            anim.SetBool("IsRunning",false);
        }
        if (isGrounded == true){
            anim.SetBool("IsJumping",false);
        }
        else{
            anim.SetBool("IsJumping",true);
        }
        
    }
    private void FixedUpdate(){
        if (canMove == true){
            rb.velocity = new Vector2(dirX,rb.velocity.y);    
        }
    }
    private void LateUpdate(){
        if(dirX <0){
            facingRight = true;
        }
        else if(dirX>0){
            facingRight=false;
        }

        if(((facingRight)&&(localScale.x<0)) || ((!facingRight)&&(localScale.x > 0))){
            localScale.x*=-1;
        }
        transform.localScale = localScale;
    }
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Floor"){
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == "Floor"){
            Debug.Log("exited");
            isGrounded = false;
        }
    }
}
