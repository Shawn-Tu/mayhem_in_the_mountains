using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Knockback : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float thrust;
    public bool Contact = false;
    public Vector2 difference = new Vector2(10f, 10);
    public int divide = 50;
    public int count = 50;
    public float differenceX;
    public float differenceY;

    //Vector2 small = new Vector2(0.01f, 0.01f);

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Damage")
        {
            Contact = true;
            //difference = (transform.position - other.transform.position);
            differenceX = difference.x / divide;
            differenceY = difference.y / divide;
            //Debug.Log(difference.x + " " + difference.y);
        }
    }

    private void Update()
    {
        Debug.Log(difference.y);
        if (Contact && count > 0)
        {
            count--;
            transform.position = new Vector2(transform.position.x + differenceX, transform.position.y + differenceY);
        }
        else
        {
            Contact=false;
            count = 10;
            difference = new Vector2(10f, 10f);
        }
    }
}
