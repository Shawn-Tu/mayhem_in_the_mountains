using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public Transform firePos;
    public GameObject bulletPrefab;
    public int currentAmmo, maxAmmo = 30, plusAmmo = 3;
    public float fireRate;
    float nextFire;

    Vector3 bulletPos;

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (!PauseMenu.isPaused)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                if (currentAmmo > 0)
                {
                    Instantiate(bulletPrefab, firePos.position, firePos.rotation);
                    currentAmmo--;
                }
            }
        }
    }

    public void AddAmmo (int ammoAmount)
    {
        currentAmmo += ammoAmount;
        if(currentAmmo > maxAmmo)
        {
            currentAmmo = maxAmmo;
        }
    }
}
