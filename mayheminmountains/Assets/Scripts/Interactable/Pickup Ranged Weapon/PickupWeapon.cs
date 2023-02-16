using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    public GameObject weaponToGive;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Pickup>().UpdateWeapon(weaponToGive);
            Destroy(GameObject.FindGameObjectWithTag("Weapon"));
            Destroy(gameObject);
        }
    }
}
