using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public void Update(){
        if(DialogueManager.isActive == true){
            moveSpeed = 0;
            return;
        } else {
            moveSpeed = 5;
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y =Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical")== 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastMoveHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastMoveVertical", Input.GetAxisRaw("Vertical"));
        }
    }

    public void FixedUpdate(){
        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    

    
}
