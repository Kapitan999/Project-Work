using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public Item SlotItem;
    Image icon;
    Button button;
    public ItemInfo itemInfo;
    public GameObject ItemObj;
    public static InventorySlot instance;
    private void Start()
    {
        instance = this;
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SlotClicked);
    }

    public void PutInSlot(Item item, GameObject obj)
    {
        icon.enabled = true;
        icon.sprite = item.icon;
        SlotItem = item;
        ItemObj = obj;
        
    }

    public void SlotClicked()
    {
            if (SlotItem != null)
            {
                itemInfo.Open(SlotItem, ItemObj, this);
            }
    }

    public void ClearSlot()
    {
        SlotItem = null;
        ItemObj = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
