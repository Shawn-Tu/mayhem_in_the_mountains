using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamage : MonoBehaviour
{
    public int bombDamage = 10;
    public int enemyDamage = 20;
    public GameObject parent;
    //PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Health>() != null)
        {
            Debug.Log("work now plz?");
            Health health = col.GetComponent<Health>();
            health.Damage(enemyDamage);
            Destroy(parent);
        }

        else if (col.GetComponent<PlayerHealth>() != null)
        {
            PlayerHealth playerHealth = col.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(bombDamage);
            Destroy(parent);
        }
        else
        {
            Nothing();
        }
        
        //if (col.GetComponent<Health>() == null & col.GetComponent<PlayerHealth>() == null)
        //{
        //    Nothing();
        //}
    }

    void Nothing()
    {
        Destroy(parent);
    }
}
