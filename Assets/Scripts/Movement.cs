using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 2000000000000f;
    
    private Rigidbody2D _rigidBody2D;
    private BoxCollider2D boxCollider2D;
    void Start()
    {
        
    }
    private void Awake()
    {
        _rigidBody2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.position += Vector3.right * -movementSpeed * Time.deltaTime;

        }
        //else if (Input.GetKeyDown(KeyCode.Space) && !isJumping) // both conditions can be in the same branch
        //{
        //    _rigidBody2D.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
        //    isJumping = true;
        //}
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float jumpVelocity = 200f;
            _rigidBody2D.velocity = Vector2.up * jumpVelocity; 
        }
    }
    //private bool IsGrounded()
    //{
    //    RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down * .1f);
    //    return raycastHit2D.collider != null;
        
    //}

}
