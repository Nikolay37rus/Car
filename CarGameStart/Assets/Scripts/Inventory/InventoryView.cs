using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour, IInventoryView
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventory;
    private bool inventoryOn;




    public event Action<IItem> Selected;

    public event Action<IItem> Deselected;
    public void Display(IReadOnlyList<IItem> items)
    {
        foreach(var item in items)
            Debug.Log($"Item Id {item.Id}, titel: {item.ItemInfo.Title}");
    }

    public void Hide()
    {
        Debug.Log($"Close Inventory");
    }

    private void OnSelected(IItem item)
    {
        Selected?.Invoke(item);
    }

    private void OnDeselected(IItem item)
    {
        Deselected?.Invoke(item);
    }


      
    
    
        private void Start()
        {
            inventoryOn = false;
        }
         public void Chest()
         {
            if(inventoryOn == false)
            {
                inventoryOn = true;
                inventory.SetActive(true);
            }
            else if (inventoryOn == true)
            {
                inventoryOn = false;
                inventory.SetActive(true);
            }

         }
}
