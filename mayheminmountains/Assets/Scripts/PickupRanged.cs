using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRanged : MonoBehaviour
{
    public GameObject fireWeapon = default;

    private void Start()
    {
        fireWeapon = transform.GetChild(1).gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameObject.FindGameObjectWithTag("Equipment"))
        {
            if (fireWeapon.activeInHierarchy == false)
            {
                fireWeapon.SetActive(true);
            }
            else
            {
                fireWeapon.SetActive(false);
            }
        }
    }
}
