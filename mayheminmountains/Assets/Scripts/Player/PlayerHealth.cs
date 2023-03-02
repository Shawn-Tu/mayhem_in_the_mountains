using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 3;
    public float currentHealth;
    public Collider2D collide;
    public GameObject playerParent;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        collide.transform.rotation = Quaternion.identity;
    }

    //player takes damage from EnemyDamage script
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            //player dies
            Debug.Log("dies");
            Destroy(playerParent);
        }
    }

    //player heals
    public void Heal(float amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            //player get more health
            Debug.Log("Power!");
        }
    }
}
