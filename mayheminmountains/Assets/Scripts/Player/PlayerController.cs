using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;


    //private GameObject attackArea = default;
    //private GameObject aimArea = default;

    //bool flippedX = true;
    //bool flippedY = true;

    void Start()
    {
        //grabs child object of character
        //attackArea = transform.GetChild(0).gameObject;
        //aimArea = transform.GetChild(1).gameObject;
    }

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

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(movement.x, movement.y, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(movement.x, movement.y, 90f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(movement.x, movement.y, 180f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(movement.x, movement.y, 270f);
        }

        //calls flip function
        //if (movement.x > 0 && !flippedX)
        //{
        //    FlipX();
        //}
        //if (movement.x < 0 && flippedX)
        //{
        //    FlipX();
        //}
        //if (movement.y > 0 && !flippedY)
        //{
        //    FlipY();
        //}
        //if (movement.y < 0 && flippedY)
        //{
        //    FlipY();
        //}
    }


    //flips character, moves sword hitbox left or right
    //void FlipX()
    //{
    //    attackArea.transform.localPosition = new Vector2(0.5f, 0);
    //    aimArea.transform.localPosition = new Vector2(0.5f, 0);
    //    Vector3 currentScale = gameObject.transform.localScale;
    //    currentScale.x *= -1;
    //    gameObject.transform.localScale = currentScale;
    //
    //
    //    flippedX = !flippedX;
    //}


    //move sword hitbox to up or down
    //void FlipY()
    //{
    //    attackArea.transform.localPosition = new Vector2(0, 0.5f);
    //    aimArea.transform.localPosition = new Vector2(0.5f, 0);
    //    Vector3 currentScale = gameObject.transform.localScale;
    //    currentScale.y *= -1;
    //    gameObject.transform.localScale = currentScale;
    //
    //    flippedY = !flippedY;
    //}

}
