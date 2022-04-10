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
                Inventory.instance.PutInEmptySlot(item, itemObj);
                if (Inventory.instance.CountOfEmptySlots <= 28)
                    gameObject.SetActive(false);
           
        }
    }
}
