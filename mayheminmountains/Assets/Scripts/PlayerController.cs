using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;

    bool flippedX = true;
    bool flippedY = true;


    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

        if (movement.x > 0 && !flippedX)
        {
            FlipX();
        }
        if (movement.x < 0 && flippedX)
        {
            FlipX();
        }
        if (movement.y > 0 && !flippedY)
        {
            FlipY();
        }
        if (movement.y < 0 && flippedY)
        {
            FlipY();
        }

    }

    void FlipX()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        flippedX = !flippedX;
    }

    void FlipY()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.y *= -1;
        gameObject.transform.localScale = currentScale;

        flippedY = !flippedY;
    }
    
}
