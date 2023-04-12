using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBombDamage : MonoBehaviour
{
    public int enemyDamage = 20;
    public GameObject parent;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.GetComponent<Health>() != null)
        {
            Health health = col.GetComponent<Health>();
            health.Damage(enemyDamage);
            Destroy(parent);
        }
        if (col.GetComponent<Health>() == null & col.GetComponent<PlayerHealth>() == null)
        {
            Nothing();
        }
    }

    void Nothing()
    {
        Destroy(parent);
    }
}
