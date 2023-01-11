using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    [SerializeField]private int damage = 3;
    public Vector3 faceLeft = new Vector3(-0.5f, 0f, 0f);
    public Vector3 faceRight = new Vector3(0.5f, 0f, 0f);

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }

    void IsFacingRight(bool IsFacingRight)
    {
        if (IsFacingRight)
        {
            gameObject.transform.position = faceRight;

        } 
        else
        {
            gameObject.transform.position = faceLeft;

        }
    }
}
