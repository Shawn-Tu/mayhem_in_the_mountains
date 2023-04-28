using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BombCounter : MonoBehaviour
{
    public TMP_Text bombCount;
    public BombSpawner bombSpawner;

    private void Update()
    {
        bombCount.text = bombSpawner.currentBomb.ToString();
    }
}
