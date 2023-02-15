using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("work plz");

            door.GetComponent<Collider2D>().enabled = false;
            Destroy(door);
            Destroy(gameObject);
        }
    }
}
