using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equip Item", menuName = "Inventory/Items/New Equip Item")]
public class PotionItrm : ItemScriptableObject
{
    public int healAmount;
    
    void Start()
    {
        type = typeOfItem.Potion;
    }

   
}
