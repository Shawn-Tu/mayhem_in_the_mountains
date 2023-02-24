using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float currentTime;

    public float startingTime = 10f;
    //public Collider2D bombRad;
    public float playerDamage = 10;

    private GameObject radius = default;

    BombDamage bombDamage;

    private void Start()
    {
        radius = transform.GetChild(0).gameObject;
        //bombRad.enabled = false;
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if(currentTime <= 0)
        {
            Explosion();
            Debug.Log("BOOM!!!");
            currentTime = 0;
            //bombRad.enabled = true;
        }
    }


    void Explosion()
    {
        radius.SetActive(true);
    }
}
