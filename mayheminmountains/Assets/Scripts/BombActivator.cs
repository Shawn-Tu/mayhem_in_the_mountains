using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombActivator : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bombChild;

    [SerializeField] GameObject hudElement;
    [SerializeField] GameObject bombCounter;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Explosions aquired");
            bombChild.SetActive(true);
            bombCounter.SetActive(true);
            Destroy(gameObject);
        }
    }
}
