using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    private Image BackGround;
    private Text Title;
    private Text Description;
    private Text CDC;
    private Text ECD;
    private Text Bleeding;
    private Text Poisoning;
    private Text ClassOfObject;
    private Button ExitButton;
    private Image UseDropImage;
    private Button UseBtn;
    private Button DropBtn;

    private Item InfoItem;
    private GameObject ItemObj;
    private InventorySlot CurrentSlot;
    public static ItemInfo instance;

    private RectTransform rectTransformImage;
    private RectTransform rectTransformImageImage;
    private RectTransform rectTransformTitle;
    private RectTransform rectTransformDescription;
    private RectTransform rectTransformCDC;
    private RectTransform rectTransformECD;
    private RectTransform rectTransformBleeding;
    private RectTransform rectTransformPoisoning;
    private RectTransform rectTransformClassOfObject;
    private RectTransform rectTransformExitBtn;
    private RectTransform rectTransformUseDropImage;
    private void Start()
    {
        instance = this;
        rectTransformImage = GetComponent<RectTransform>();
        rectTransformImageImage = transform.GetChild(0).GetComponent<RectTransform>();
        rectTransformTitle = transform.GetChild(1).GetComponent<RectTransform>();
        rectTransformDescription = transform.GetChild(2).GetComponent<RectTransform>();
        rectTransformCDC = transform.GetChild(3).GetComponent<RectTransform>();
        rectTransformECD = transform.GetChild(4).GetComponent<RectTransform>();
        rectTransformBleeding = transform.GetChild(5).GetComponent<RectTransform>(); 
        rectTransformPoisoning = transform.GetChild(6).GetComponent<RectTransform>();
        rectTransformClassOfObject = transform.GetChild(7).GetComponent<RectTransform>();
        rectTransformExitBtn = transform.GetChild(8).GetComponent<RectTransform>();
        rectTransformUseDropImage = transform.GetChild(9).GetComponent<RectTransform>();

        BackGround = GetComponent<Image>();
        Title = transform.GetChild(1).GetComponent<Text>();
        Description = transform.GetChild(2).GetComponent<Text>();
        CDC = transform.GetChild(3).GetComponent<Text>();
        ECD = transform.GetChild(4).GetComponent<Text>();
        Bleeding = transform.GetChild(5).GetComponent<Text>();
        Poisoning = transform.GetChild(6).GetComponent<Text>();
        ClassOfObject = transform.GetChild(7).GetComponent<Text>();
        ExitButton = transform.GetChild(8).GetComponent<Button>();
        UseBtn = transform.GetChild(9).GetChild(0).GetComponent<Button>();
        DropBtn = transform.GetChild(9).GetChild(1).GetComponent<Button>();
        Close();
        ExitButton.onClick.AddListener(Close);
        UseBtn.onClick.AddListener(Use);
        DropBtn.onClick.AddListener(Drop);
    }

    public void ChangeInfo(Item item)
    {
        Title.text = item.Name;
        Description.text = item.Description;
        CDC.text = item.CritDamageChance;
        ECD.text = item.ExtraCritDamage;
        Bleeding.text = item.Bleeding;
        Poisoning.text = item.Poisoning;
        ClassOfObject.text = item.ObjClass;
        if ((item.CritDamageChance == "") & (item.ExtraCritDamage == "") & (item.Bleeding == "") & (item.Poisoning == ""))
        {
            rectTransformImage.sizeDelta = new Vector2(270, 105);
            rectTransformImageImage.localPosition = new Vector3(rectTransformImageImage.localPosition.x, 35, rectTransformImageImage.localPosition.z);
            rectTransformTitle.localPosition = new Vector3(rectTransformTitle.localPosition.x, 35, rectTransformTitle.localPosition.z);
            rectTransformDescription.localPosition = new Vector3(rectTransformDescription.localPosition.x, 0, rectTransformDescription.localPosition.z);
            rectTransformClassOfObject.localPosition = new Vector3(rectTransformClassOfObject.localPosition.x, -35, rectTransformClassOfObject.localPosition.z);
            rectTransformUseDropImage.localPosition = new Vector3(rectTransformUseDropImage.localPosition.x, -70, rectTransformUseDropImage.localPosition.z);
            rectTransformExitBtn.localPosition = new Vector3(135, 52.5f, rectTransformExitBtn.localPosition.z);
            rectTransformCDC.localScale = Vector3.zero;
            rectTransformECD.localScale = Vector3.zero;
            rectTransformBleeding.localScale = Vector3.zero;
            rectTransformPoisoning.localScale = Vector3.zero;

        }
        else if((item.ExtraCritDamage == "") & (item.Bleeding == "") & (item.Poisoning == ""))
        {
            rectTransformImage.sizeDelta = new Vector2(270, 175);
            rectTransformImageImage.localPosition = new Vector3(rectTransformImageImage.localPosition.x,  70, rectTransformImageImage.localPosition.z);
            rectTransformTitle.localPosition = new Vector3(rectTransformTitle.localPosition.x, 70, rectTransformTitle.localPosition.z);
            rectTransformDescription.localPosition = new Vector3(rectTransformDescription.localPosition.x, 35, rectTransformDescription.localPosition.z);
            rectTransformCDC.localPosition = new Vector3(rectTransformCDC.localPosition.x,  0, rectTransformCDC.localPosition.z);
            rectTransformClassOfObject.localPosition = new Vector3(rectTransformClassOfObject.localPosition.x,  -35, rectTransformClassOfObject.localPosition.z);
            rectTransformUseDropImage.localPosition = new Vector3(rectTransformUseDropImage.localPosition.x, -70, rectTransformUseDropImage.localPosition.z);
            rectTransformExitBtn.localPosition = new Vector3(135,  87.5f, rectTransformExitBtn.localPosition.z);
            rectTransformECD.localScale = Vector3.zero;
            rectTransformBleeding.localScale = Vector3.zero;
            rectTransformPoisoning.localScale = Vector3.zero;
            rectTransformCDC.localScale = Vector3.one;
        }

        else if((item.Bleeding == "") & (item.Poisoning == ""))
        {
            rectTransformImage.sizeDelta = new Vector2(270, 210);
            rectTransformImageImage.localPosition = new Vector3(rectTransformImageImage.localPosition.x, 87.5f, rectTransformImageImage.localPosition.z);
            rectTransformTitle.localPosition = new Vector3(rectTransformTitle.localPosition.x, 87.5f, rectTransformTitle.localPosition.z);
            rectTransformDescription.localPosition = new Vector3(rectTransformDescription.localPosition.x, 52.5f, rectTransformDescription.localPosition.z);
            rectTransformCDC.localPosition = new Vector3(rectTransformCDC.localPosition.x, 17.5f, rectTransformCDC.localPosition.z);
            rectTransformECD.localPosition = new Vector3(rectTransformECD.localPosition.x, -17.5f, rectTransformECD.localPosition.z);
            rectTransformClassOfObject.localPosition = new Vector3(rectTransformClassOfObject.localPosition.x, -52.5f, rectTransformClassOfObject.localPosition.z);
            rectTransformUseDropImage.localPosition = new Vector3(rectTransformUseDropImage.localPosition.x, -87.5f, rectTransformUseDropImage.localPosition.z);
            rectTransformExitBtn.localPosition = new Vector3(135,  105, rectTransformExitBtn.localPosition.z);
            rectTransformBleeding.localScale = Vector3.zero;
            rectTransformPoisoning.localScale = Vector3.zero;
            rectTransformCDC.localScale = Vector3.one;
            rectTransformECD.localScale = Vector3.one;
        }

        else if (item.Poisoning == "")
        {
            rectTransformImage.sizeDelta = new Vector2(270, 245);
            rectTransformImageImage.localPosition = new Vector3(rectTransformImageImage.localPosition.x, 105, rectTransformImageImage.localPosition.z);
            rectTransformTitle.localPosition = new Vector3(rectTransformTitle.localPosition.x, 105, rectTransformTitle.localPosition.z);
            rectTransformDescription.localPosition = new Vector3(rectTransformDescription.localPosition.x,  70, rectTransformDescription.localPosition.z);
            rectTransformCDC.localPosition = new Vector3(rectTransformCDC.localPosition.x, 35, rectTransformCDC.localPosition.z);
            rectTransformECD.localPosition = new Vector3(rectTransformECD.localPosition.x, 0, rectTransformECD.localPosition.z);
            rectTransformBleeding.localPosition = new Vector3(rectTransformBleeding.localPosition.x, -35, rectTransformBleeding.localPosition.z);
            rectTransformClassOfObject.localPosition = new Vector3(rectTransformClassOfObject.localPosition.x,  -70, rectTransformClassOfObject.localPosition.z);
            rectTransformUseDropImage.localPosition = new Vector3(rectTransformUseDropImage.localPosition.x, -105, rectTransformUseDropImage.localPosition.z);
            rectTransformExitBtn.localPosition = new Vector3(135, 122.5f, rectTransformExitBtn.localPosition.z);
            rectTransformPoisoning.localScale = Vector3.zero;
            rectTransformCDC.localScale = Vector3.one;
            rectTransformECD.localScale = Vector3.one;
            rectTransformBleeding.localScale = Vector3.one;
        }
        else
        {
            rectTransformImage.sizeDelta = new Vector2(270, 280);
            rectTransformImageImage.localPosition = new Vector3(rectTransformImageImage.localPosition.x, 122.5f, rectTransformImageImage.localPosition.z);
            rectTransformTitle.localPosition = new Vector3(rectTransformTitle.localPosition.x, 122.5f, rectTransformTitle.localPosition.z);
            rectTransformDescription.localPosition = new Vector3(rectTransformDescription.localPosition.x, 87.5f, rectTransformDescription.localPosition.z);
            rectTransformCDC.localPosition = new Vector3(rectTransformCDC.localPosition.x, 52.5f, rectTransformCDC.localPosition.z);
            rectTransformECD.localPosition = new Vector3(rectTransformECD.localPosition.x, 17.5f, rectTransformECD.localPosition.z);
            rectTransformBleeding.localPosition = new Vector3(rectTransformBleeding.localPosition.x,  -17.5f, rectTransformBleeding.localPosition.z);
            rectTransformPoisoning.localPosition = new Vector3(rectTransformPoisoning.localPosition.x, -52.5f, rectTransformPoisoning.localPosition.z);
            rectTransformClassOfObject.localPosition = new Vector3(rectTransformClassOfObject.localPosition.x,  -87.5f, rectTransformClassOfObject.localPosition.z);
            rectTransformUseDropImage.localPosition = new Vector3(rectTransformUseDropImage.localPosition.x, -122.5f, rectTransformUseDropImage.localPosition.z);
            rectTransformExitBtn.localPosition = new Vector3(135,  140, rectTransformExitBtn.localPosition.z);
            rectTransformCDC.localScale = Vector3.one;
            rectTransformECD.localScale = Vector3.one;
            rectTransformBleeding.localScale = Vector3.one;
            rectTransformPoisoning.localScale = Vector3.one;
        }
       


        
    }



    public void Use()
    {
        UseOfItems.instance.Use(InfoItem);
        if ((Inventory.instance.flag != 1) & (InfoItem.TypeOfObj == "Sword"))
        {
            Inventory.instance.CountOfEmptySlots -= 1;
            CurrentSlot.ClearSlot();
            Close();
        }
        else
        {
            Inventory.instance.CountOfEmptySlots -= 1;
            CurrentSlot.ClearSlot();
            Close();
        }
        
    }


    public void Drop()
    {
        Vector3 DropPos = new Vector3(HeroMain.instance.transform.position.x + 3f, HeroMain.instance.transform.position.y, HeroMain.instance.transform.position.z);
        ItemObj.SetActive(true);
        ItemObj.transform.position = DropPos;
        Inventory.instance.CountOfEmptySlots -= 1;
        CurrentSlot.ClearSlot();
        Close();
    }


    public void Open(Item item, GameObject itemObj, InventorySlot currentSlot)
    {
        ChangeInfo(item);
        InfoItem = item;
        ItemObj = itemObj;
        CurrentSlot = currentSlot;
        gameObject.transform.localScale = Vector3.one;
        ItemInfoCharacter.instance.Close();
    }

    public void Close()
    {
        gameObject.transform.localScale = Vector3.zero;
    }
}
