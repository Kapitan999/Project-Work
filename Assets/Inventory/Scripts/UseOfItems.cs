using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseOfItems : MonoBehaviour
{
    public static UseOfItems instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void Use(Item item)
    {
        if(item.TypeOfObj == "Food")
        {

            Debug.Log("HIIIL!!!!");
        }
        if(item.TypeOfObj == "Sword")
        {
            Inventory.instance.PutInCharacterSlot(item, InventorySlot.instance.ItemObj);
        }
    }
}
