using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRanged : MonoBehaviour
{
    //public GameObject fireWeapon = default;

    [SerializeField] GameObject player;
    [SerializeField] GameObject rangeChild;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("work?");
        rangeChild.SetActive(true);
        Destroy(gameObject);
    }
}
