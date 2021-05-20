using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.UIElements;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    
    public GameObject UIPanel;
    public Transform inventoryPanel;
    public List<InventorySlot> slots = new List<InventorySlot>();
    public List<InventorySlot> equipSlots = new List<InventorySlot>();
    public bool isOpened;
    public float reachDistance = 3f;
    public bool slotFool = false;
    
    void Start()
    {
        UIPanel.SetActive(false);
        
        for(int i = 0; i < inventoryPanel.childCount; i++)
        {
            if(inventoryPanel.GetChild(i).GetComponent<InventorySlot>() != null)
            {
                slots.Add(inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
            }
        }
    }

     
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpened = !isOpened;
            if (isOpened)
            {
                UIPanel.SetActive(true);
                Time.timeScale = 0;
                
            }
            else
            {
                UIPanel.SetActive(false);
                Time.timeScale = 1;
            }
        } 
    }

    public InventorySlot GetFreeEquipSlotOrDefault()
    {
        return equipSlots.FirstOrDefault(slot => slot.holdType == typeOfItem.Equip && slot.isEmpty);
    }

    public void AddItem(ItemScriptableObject _item, int _amount)
    {
        foreach (InventorySlot slot in slots)
        {
            if (slot.amount == _item.maxAmount)
                slotFool = true;
            else if (slot.amount < _item.maxAmount)
                slotFool = false;

            if (slot.item == _item && slotFool == false)
            {
                if (slot.amount + _amount <= _item.maxAmount)
                {
                    slot.SetIcon(_item.itemIcon);
                    slot.amount += _amount;
                    slot.itemAmountText.text = slot.amount.ToString();
                    return;
                }
                break;
            }
            if (slot.isEmpty == true)
            {

                slot.item = _item;
                slot.amount = _amount;
                slot.isEmpty = false;
                slot.SetIcon(_item.itemIcon);
                if (_item.maxAmount > 1)
                {
                    slot.itemAmountText.text = slot.amount.ToString();
                }
                break;
            }
 

        }
        
    }
}
