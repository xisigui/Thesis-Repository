using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    
    public Rigidbody2D rb;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkzone;
    private bool hasWalkzone;

    public Animator animator;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();
        if(walkzone != null){
            minWalkPoint = walkzone.bounds.min;
            maxWalkPoint = walkzone.bounds.max;
            hasWalkzone = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isWalking){
            walkCounter -= Time.deltaTime;
           
                waitCounter = waitTime;
                switch(walkDirection){
                    case 0: 
                        rb.velocity = new Vector2(0, moveSpeed);
                        if(hasWalkzone && transform.position.y > maxWalkPoint.y){
                            isWalking = false;
                            walkCounter = waitTime;
                        }
                        animator.SetFloat("Horizontal", movement.x);
                        animator.SetFloat("Vertical", movement.y);
                        animator.SetFloat("Speed", movement.sqrMagnitude);
                        break;

                    case 1: 
                         rb.velocity = new Vector2(moveSpeed, 0);
                         if(hasWalkzone && transform.position.y > maxWalkPoint.x){
                            isWalking = false;
                            walkCounter = waitTime;
                        }
                        break;
                    case 2: 
                        rb.velocity = new Vector2(0, -moveSpeed);
                        if(hasWalkzone && transform.position.y > minWalkPoint.y){
                            isWalking = false;
                            walkCounter = waitTime;
                        }
                        break;
                    case 3: 
                        rb.velocity = new Vector2(-moveSpeed, 0);
                        if(hasWalkzone && transform.position.y > minWalkPoint.x){
                            isWalking = false;
                            walkCounter = waitTime;
                        }
                        break;
                }

            if(walkCounter < 0)
            {
                isWalking = false;
                walkCounter = waitTime; 
            }
        } else {
            waitCounter -= Time.deltaTime;
            rb.velocity = Vector2.zero;
            if(waitCounter<0){
                ChooseDirection();
            }

        }
        
 
    }

    private void ChooseDirection(){
        walkDirection = Random.Range(0,4);
        isWalking = true;
        walkCounter = waitTime;
    }
}
