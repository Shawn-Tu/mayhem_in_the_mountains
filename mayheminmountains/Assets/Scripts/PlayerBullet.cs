using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public GameObject player;

    //Vector2 movement;

    //bool directionShoot = false;

    private void Update()
    {
        
    }

    private void Awake()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        Vector3 currentScale = player.transform.localScale;
        if (currentScale.x == -1 && currentScale.y == 1)
        {
            rb.velocity = transform.right * -1 * speed;
        }
        else if (currentScale.x == 1 && currentScale.y == 1)
        {
            rb.velocity = transform.right * speed;
        }

        else if (currentScale.y == -1)
        {
            rb.velocity = transform.up * -1 * speed;
        }
        else
        {
            rb.velocity = transform.up * speed;
        }


        //if(upDown == false && leftRight == true)
        //{
        //    LeftRightShoot();
        //}
        //if(upDown == true && leftRight == false)
        //{
        //    UpDownShoot();
        //}
    }
}
