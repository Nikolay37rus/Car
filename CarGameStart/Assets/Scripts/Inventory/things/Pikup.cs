using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikup : MonoBehaviour
{
    private InventoryView inventory;
    public GameObject slotButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryView>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i <inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] ==false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }


}
