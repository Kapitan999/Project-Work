using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public Item item;
    private GameObject itemObj;
    private void Start()
    {
        itemObj = gameObject;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
         
            if(Inventory.instance.CountOfEmptySlots <= 27)
            {
                Inventory.instance.PutInEmptySlot(item, itemObj);
                gameObject.SetActive(false);
            }
      
        }
    }
}
