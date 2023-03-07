using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    //[SerializeField] PlayerFire playerFire;
    public GameObject parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerFire playerFire = collision.gameObject.GetComponentInChildren<PlayerFire>();
        if (playerFire)
        {
            playerFire.AddAmmo(playerFire.plusAmmo);
            Destroy(gameObject);
        }
    }
}
