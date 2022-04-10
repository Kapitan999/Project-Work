using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public Transform SlotsParent;
    public Transform SlotsCharacter;
    private InventorySlot[] inventorySlots = new InventorySlot[28];
    private CharacterSlot[] characterSlots = new CharacterSlot[12];
    bool isOpened = true;
    public ItemInfo itemInfo;
    public int CountOfEmptySlots = 0;
    public ItemInfoCharacter ItemInfoCharacter;
    public int flag = 0;
    private void Start()
    {
        instance = this;
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i] = SlotsParent.GetChild(i).GetComponent<InventorySlot>();
        }
        for (int i = 0; i < characterSlots.Length; i++)
        {
            characterSlots[i] = SlotsCharacter.GetChild(i).GetComponent<CharacterSlot>();
        }
        if (isOpened)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

   

    public void PutInEmptySlot(Item item, GameObject obj)
    {
        CountOfEmptySlots += 1;
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].SlotItem == null) 
            {  
                inventorySlots[i].PutInSlot(item, obj);
                
                return;
            }
            
        }
    }


    public void PutInCharacterSlot(Item item, GameObject obj)
    {
        if(characterSlots[2].CharacterSlotItem == null)
        {
            characterSlots[2].PutInCSlot(item, obj);
            flag = 1;
        }
        else
        {
            flag = 0;
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            if (isOpened)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
        
    }

    void Open()
    {
        gameObject.transform.localScale = Vector3.one;
        isOpened = true;
    }

    void Close()
    {
        gameObject.transform.localScale = Vector3.zero;
        isOpened = false;
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].itemInfo.Close();
        }
        for (int i = 0; i < characterSlots.Length; i++)
        {
            characterSlots[i].itemInfoCharacter.Close();
        }
    }
}
