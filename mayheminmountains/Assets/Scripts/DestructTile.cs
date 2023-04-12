using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestructTile : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bombable")
        {
            Debug.Log("work or no");
            //Destroy(col.gameObject);
        }
    }


}
