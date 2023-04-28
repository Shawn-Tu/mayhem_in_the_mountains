using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyCounter : MonoBehaviour
{
    public static CurrencyCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = currentCoins.ToString();
    }

    public void IncreaseCurrency(int v)
    {
        currentCoins += v;
        coinText.text = currentCoins.ToString();
    }
}
