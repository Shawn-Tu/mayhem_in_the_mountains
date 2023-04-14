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
        Health health = col.GetComponent<Health>();
        PlayerHealth playerHealth = col.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            Debug.Log("player takes a kaboom");
            playerHealth.TakeDamage(bombDamage);
            Destroy(parent);
        }

        if (health != null)
        {
            Debug.Log("work now plz?");
            health.Damage(enemyDamage);
            Destroy(parent);
        }

        else if (health == null & playerHealth == null)
        {
            Nothing();
        }
    }

    void Nothing()
    {
        Debug.Log("Nothing happened lol");
        Destroy(parent);
    }
}
