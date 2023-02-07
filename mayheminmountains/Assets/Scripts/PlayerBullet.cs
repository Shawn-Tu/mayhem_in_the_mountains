using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private GameObject player;

    //Vector2 movement;

    bool upDown;
    bool leftRight;

    
    private void Awake()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        Vector3 currentScale = player.transform.localScale;

        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.D))
        {
            upDown = false;
            leftRight = true;
            LeftRightShoot();
        }
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.S))
        {
            upDown = true;
            leftRight = false;
            UpDownShoot();
        }
        if(upDown == false && leftRight == true)
        {
            LeftRightShoot();
        }
        if(upDown == true && leftRight == false)
        {
            UpDownShoot();
        }
    }

    //shoot left or right
    public void LeftRightShoot()
    {
        Vector3 currentScale = player.transform.localScale;
        if (currentScale.x == -1)
        {
            rb.velocity = transform.right * -1 * speed;
        }
        else if (currentScale.x == 1)
        {
            rb.velocity = transform.right * speed;
        }
    }
    //shoot up or down
    public void UpDownShoot()
    {
        
        Vector3 currentScale = player.transform.localScale;
        if (currentScale.y == -1)
        {
            rb.velocity = transform.up * -1 * speed;
        }
        else if (currentScale.y == 1)
        {
            rb.velocity = transform.up * speed;
        }
    }

    
}
