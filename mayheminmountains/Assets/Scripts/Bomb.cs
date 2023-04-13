using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float currentTime;

    public float startingTime = 10f;
    public float playerDamage = 10;

    private GameObject radius = default;

    BombDamage bombDamage;

    bool entityCheck = false;

    private void Start()
    {
        radius = transform.GetChild(0).gameObject;
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if(currentTime <= 0)
        {
            currentTime = 0;
            if (entityCheck == false)
            {
                Destroy(gameObject);
            }
            else
            {
                Explosion();
            }
            Debug.Log("BOOM!!!");
        }
    }


    void Explosion()
    {
        radius.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerHealth>() != null | col.GetComponent<Health>() != null)
        {
            entityCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        entityCheck = false;
    }
}
