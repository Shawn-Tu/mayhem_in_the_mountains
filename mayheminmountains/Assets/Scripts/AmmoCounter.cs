using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text ammoCount;
    public PlayerFire playerFire;

    private void Update()
    {
        ammoCount.text = "Ammo: " + playerFire.currentAmmo.ToString();
    }

}
