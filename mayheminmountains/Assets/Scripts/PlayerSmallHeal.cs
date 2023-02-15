using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmallHeal : MonoBehaviour
{
    public float heal = 2;
    public PlayerHealth health;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            health.Heal(heal);
        }
    }
}
