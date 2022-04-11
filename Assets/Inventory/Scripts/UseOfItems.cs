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
    public void Use(Item item, GameObject obj, InventorySlot Slot)
    {
        if(item.TypeOfObj == "Food")
        {
            Inventory.instance.CountOfEmptySlots -= 1;
            Slot.ClearSlot();
            ItemInfo.instance.Close();
            Debug.Log("HIIIL!!!!");
        }
        if (item.TypeOfObj == "Sword")
        {
            Inventory.instance.PutInCharacterSlot(item, obj);
            if (Inventory.instance.flag == 1)
            {
                Inventory.instance.CountOfEmptySlots -= 1;
                Slot.ClearSlot();
                ItemInfo.instance.Close();
            }
        }

    }
}
