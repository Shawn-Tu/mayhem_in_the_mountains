using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmallHeal : MonoBehaviour
{
    public float heal = 2;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var healthComp = col.GetComponent<PlayerHealth>();
            if(healthComp != null)
            {
                Debug.Log("HEALTH");
                healthComp.Heal(heal);
                Destroy(gameObject);
            }
        }
    }
}
