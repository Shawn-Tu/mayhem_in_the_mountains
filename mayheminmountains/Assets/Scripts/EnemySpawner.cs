using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player.tag == "PlayerManager")
        {
            Debug.Log("Enemy Spawn");
            //parent.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(player.tag == "PlayerManager")
        {
            Debug.Log("Enemy NO Spawn");
            //parent.SetActive(false);
        }
    }
}
