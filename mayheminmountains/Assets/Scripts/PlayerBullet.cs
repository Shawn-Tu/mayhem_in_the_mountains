using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (movement.y > 0)
        {
            rb.velocity = transform.up * speed;
        }
        if (movement.y < 0)
        {
            rb.velocity = -transform.up * speed;
        }

        if (movement.x > 0)
        {
            rb.velocity = transform.right * speed;
        }
        if (movement.x < 0)
        {
            rb.velocity = -transform.right * speed;
        }
        //rb.velocity = transform.right * speed;
    }

    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        
    }
}
