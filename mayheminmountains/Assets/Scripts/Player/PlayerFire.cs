using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    public Transform firePos;
    public GameObject bulletPrefab;
    public int currentAmmo, maxAmmo = 30, plusAmmo = 3;
    public float fireRate;

    public float timeToAttack = 0.25f;
    public float timer = 0f;

    float nextFire;

    public PlayerController playerController;
    public AnimationController animationController;

    Vector3 bulletPos;

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & Time.time >= nextFire)
        {
            Shoot();
            playerController.stop = true;
        }

        timer += Time.deltaTime;
        if (timer >= timeToAttack)
        {
            timer = 0;
            playerController.stop = false;
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

    void keepMove()
    {
        playerController.stop = false;
        Debug.Log("does this work?");
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
