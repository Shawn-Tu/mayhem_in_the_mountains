using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public Transform bombPos;
    public GameObject bombPrefab;
    public int currentBomb, maxBomb = 10, plusBomb = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlaceBomb();
        }
    }

    void PlaceBomb()
    {
        if (!PauseMenu.isPaused)
        {
            if(currentBomb > 0)
            {
                Instantiate(bombPrefab, bombPos.position, bombPos.rotation);
                currentBomb--;
            }
        }
    }

    public void AddBomb (int bombAmount)
    {
        currentBomb += bombAmount;
        if(currentBomb > maxBomb)
        {
            currentBomb = maxBomb;
        }
    }
}
