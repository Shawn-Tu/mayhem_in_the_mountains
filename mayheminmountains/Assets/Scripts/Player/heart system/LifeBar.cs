using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBar : MonoBehaviour
{
    public GameObject heartPrefab;
    public float health, maxHealth;
    List<HeartManager> hearts = new List<HeartManager>();

    private void Start()
    {
        DrawHearts();
    }

    public void DrawHearts()
    {
        //12 -> 3 hearts
        ClearHearts();

        //determine how many hearts to make total
        //based on the max health

        float maxHealthRemainder = maxHealth % 2; //checks odd or even
        int heartsToMake = (int)(maxHealth / 4 + maxHealthRemainder); //determines hearts on screen
        for(int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        //updates hearts according to current health 
        for(int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(health - (i * 4), 0, 4);
            hearts[i].SetHeartImage((HeartStatus)heartStatusRemainder);
        }
    }


    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HeartManager heartComponent = newHeart.GetComponent<HeartManager>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }


    //clears hearts within the parent
    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HeartManager>();
    }
    
}
