using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterSlot : MonoBehaviour
{
    public Item CharacterSlotItem;
    Image icon;
    Button button;
    public ItemInfoCharacter itemInfoCharacter;
    public GameObject CharacterItemObj;
    public static CharacterSlot instance;
    private void Start()
    {
        instance = this;
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(CharacterSlotClicked);
    }

    public void CharacterSlotClicked()
    {
        if (CharacterSlotItem != null)
        {
            itemInfoCharacter.Open(CharacterSlotItem, CharacterItemObj, this);
        }
    }



    public void PutInCSlot(Item item, GameObject obj)
    {
        icon.enabled = true;
        icon.sprite = item.icon;
        CharacterSlotItem = item;
        CharacterItemObj = obj;
    }


    public void ClearSlot()
    {
        CharacterSlotItem = null;
        CharacterItemObj = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}