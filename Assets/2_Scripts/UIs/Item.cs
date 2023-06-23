using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "RPGSystem/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public string name;
    public string description;
    public GameObject model;
    public int rarity;
}
