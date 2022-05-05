using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed = 1000f;
    public int damage = 20;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;   
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        Pierce pierce = collision.GetComponent<Pierce>();
        if(pierce != null)
        {
            pierce.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
