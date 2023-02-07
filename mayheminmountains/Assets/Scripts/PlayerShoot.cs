using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public float fireForce = 20;
    
    //public void Fire()
    //{
    //    GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
    //    bullet.GetComponent<Rigidbody2D>().AddForce(shootingPoint.up * fireForce, ForceMode2D.Impulse);
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);        
        }
    }
}
