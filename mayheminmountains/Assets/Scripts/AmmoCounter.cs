using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoCounter : MonoBehaviour
{
    public static AmmoCounter instance;

    public TMP_Text ammoText;
    public int currentAmmo = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ammoText.text = "Currency: " + currentAmmo.ToString();
    }

    public void IncreaseAmmo(int v)
    {
        currentAmmo += v;
        ammoText.text = "Currency: " + currentAmmo.ToString();
    }
}
