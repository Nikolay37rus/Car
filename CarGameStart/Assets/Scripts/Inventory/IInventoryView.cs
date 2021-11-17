using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryView 
{
    void Display(IReadOnlyList<IItem> items);
}

//public class IInventoryView : MonoBehaviour
//{
//
//    public bool[] isFull;
//    public GameObject[] slots;
//    public GameObject inventory;
//    private bool inventoryOn;
//
//
//
//    private void Start()
//    {
//        inventoryOn = false;
//    }
//     public void Chest()
//    {
//        if(inventoryOn == false)
//        {
//            inventoryOn = true;
//            inventory.SetActive(true);
//        }
//        else if (inventoryOn == true)
//        {
//            inventoryOn = false;
//            inventory.SetActive(true);
//        }
//    }
//}