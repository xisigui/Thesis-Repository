using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundedNPC : MonoBehaviour
{

    private Vector3 directionvector;
    private Transform mytransform;
    public float speed;
    private Rigidbody2D rb;
    private Animator animator;
    public Collider2D bounds;
    // Start is called before the first frame update
    void Start()
    {
        mytransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        Move();        
    }

    private void Move()
    {
        Vector3 temp = mytransform.position + directionvector * speed * Time.deltaTime;
        if(bounds.bounds.Contains(temp)){
            rb.MovePosition(temp);
        } else {
            ChangeDirection();
        }
        
    }

    void ChangeDirection(){

        int direction = Random.Range(0,4);

        switch(direction){
            case 0:
                directionvector = Vector3.right;
                break;
            case 1:
                directionvector = Vector3.up;
                break;
            case 2:
                directionvector = Vector3.left;
                break;
            case 3:
                directionvector = Vector3.down;
                break;
            default:
                break;
        }
        UpdateAnimation();
    }

     void UpdateAnimation(){
        animator.SetFloat("Horizontal", directionvector.x);
        animator.SetFloat("Vertical", directionvector.y);
    }
    /*
    private void OnCollisionEnter2D(Collision2D other){
        Vector3 temp = directionvector;
        ChangeDirection();
        int loops = 0;
        while(temp == directionvector && loops < 100){
            loops++;
            ChangeDirection();
        }
    }
    */
}
