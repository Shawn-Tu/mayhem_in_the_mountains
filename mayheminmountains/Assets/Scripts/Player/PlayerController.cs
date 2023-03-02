using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Collider2D boxCollider;


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
        boxCollider.transform.position = transform.position;

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
    }
}
