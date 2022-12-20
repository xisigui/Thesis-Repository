using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed;
    public float checkRadius;
    public float attackRadius;
    public bool shouldRotate;
    public LayerMask playerLayer;
    private Transform target;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;
    public Vector3 dir;
    private bool isInChaseRange;
    private bool isInAttackRange;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update(){
        animator.SetBool("IsRunning", isInChaseRange);
        isInChaseRange = Physics2D.OverlapCircle(transform.position, checkRadius, playerLayer);
        isInAttackRange= Physics2D.OverlapCircle(transform.position, attackRadius, playerLayer);

        dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        dir.Normalize();
        movement = dir;
        if(shouldRotate){
            animator.SetFloat("X", dir.x);
            animator.SetFloat("Y", dir.y);
        }
    }

    private void FixedUpdate(){
        if(isInChaseRange && !isInAttackRange){
           MoveCharacter(movement); 
        }
        if(isInAttackRange){
            rb.velocity = Vector2.zero;
        }
    }

    private void MoveCharacter(Vector2 dir){
        rb.MovePosition((Vector2)transform.position + (dir * speed * Time.deltaTime)); 
    }
}
