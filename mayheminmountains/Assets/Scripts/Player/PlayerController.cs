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

    //bool stops player when attacking
    public bool stop;

    void Start()
    {
        
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
        if (stop == false)
        {
            //movement
            rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

            if (Input.GetKey(KeyCode.W))
            {
                boxCollider.transform.rotation = Quaternion.identity;
                transform.rotation = Quaternion.Euler(movement.x, movement.y, 0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                boxCollider.transform.rotation = Quaternion.identity;
                transform.rotation = Quaternion.Euler(movement.x, movement.y, 90f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                boxCollider.transform.rotation = Quaternion.identity;
                transform.rotation = Quaternion.Euler(movement.x, movement.y, 180f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                boxCollider.transform.rotation = Quaternion.identity;
                transform.rotation = Quaternion.Euler(movement.x, movement.y, 270f);
            }
        }
    }
}
