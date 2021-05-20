using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum typeOfItem
{
    Any,
    Equip,
    Potion,
    Utility,
    QuestItem,
    Components,
    Resourse
}
public class ItemScriptableObject : ScriptableObject
{
    public typeOfItem type;
    public string name;
    public int maxAmount;
    public string itemDescription;
    public GameObject itemPref;
    public Sprite itemIcon;
    
}
