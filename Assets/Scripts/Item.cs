using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, ItemBase
{
    public ItemScriptableObject item;
    public int amount;

    public void SetAmount(int amount)
    {
        this.amount = amount;
    }

    void OnTriggerStay(Collider collider)
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            var inventory = collider.gameObject.GetComponent<InventoryManager>();
            if (inventory != null )
            {
                inventory.AddItem(item, amount);
                Destroy(gameObject);
            }
            
        }

    }

}
