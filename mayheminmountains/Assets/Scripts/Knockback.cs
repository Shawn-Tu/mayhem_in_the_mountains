using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Knockback : MonoBehaviour
{
    public bool Contact = false;
    public Vector2 difference = new Vector2(10f, 10);
    public int divide;
    public int count = 10;
    public float differenceX;
    public float differenceY;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Damage")
        {
            Contact = true;
            difference = (transform.position - other.transform.position);
            differenceX = difference.x / divide;
            differenceY = difference.y / divide;
        }
    }

    private void Update()
    {
        if (Contact && count > 0)
        {
            count--;
            transform.position = new Vector2(transform.position.x + differenceX, transform.position.y + differenceY);
        }
        else
        {
            Contact=false;
            count = 10;
        }
    }
}
