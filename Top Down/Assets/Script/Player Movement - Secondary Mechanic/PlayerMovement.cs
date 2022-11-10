using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    
    private bool facingRight = true;

    private Vector2 moveDirection;

    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs(); 
    }
    void FixedUpdate(){
        Move();
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
/*
        if(moveX == 0){
            anim.SetBool("isRun", false);
        } else {
            anim.SetBool("isRun", true);
        }
*/
        moveDirection = new Vector2(moveX, moveY).normalized;

        if(moveX < 0 && facingRight){
            Flip();
        } else if (moveX > 0 && !facingRight){
            Flip();
        }
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Flip(){
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
    }

    
}
