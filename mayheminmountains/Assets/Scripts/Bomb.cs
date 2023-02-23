using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;
    public Collider2D bombRad;

    private void Start()
    {
        bombRad.enabled = false;
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if(currentTime <= 0)
        {
            Debug.Log("BOOM!!!");
            currentTime = 0;
            bombRad.enabled = true;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("BRO U DEAD");
        }
    }
}
