using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Drops : ScriptableObject
{
    public Sprite itemSprite;
    public string itemName;
    public int dropChance;

    public Drops(string itemName, int dropChance)
    {
        this.itemName = itemName;
        this.dropChance = dropChance;
    }
}
