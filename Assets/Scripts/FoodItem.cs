using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Utility Item", menuName = "Inventory/Items/New Utility Item")]

public class FoodItem : ItemScriptableObject
{
    public float healAmount;

    private void Start()
    {
        type = typeOfItem.Utility;
    }
}
