using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float projectileSpeed;
    public Rigidbody2D rb;

    [SerializeField] private int damage = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
            Destroy(gameObject);
        }
    }
}
