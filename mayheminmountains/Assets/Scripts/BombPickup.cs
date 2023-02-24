using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BombSpawner bombSpawner = collision.gameObject.GetComponentInChildren<BombSpawner>();
        if (bombSpawner)
        {
            bombSpawner.AddBomb(bombSpawner.plusBomb);
            Destroy(gameObject);
        }
    }
}
