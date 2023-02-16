using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    public GameObject healthPrefab;
    public GameObject currencyPrefab;
    public GameObject ammoPrefab;

    // Update is called once per frame

    public void Damage(int amount)
    {

        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        int chance = Random.Range(1, 10);
        //spawn health
        if(chance <= 4)
        {
            Instantiate(healthPrefab, transform.position, Quaternion.identity);
        }
        else if(chance >= 5 & chance <= 7)
        {
            Instantiate(currencyPrefab, transform.position, Quaternion.identity);
        }
        else if(chance >= 8)
        {
            Instantiate(ammoPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
        Debug.Log("death");
    }
}
