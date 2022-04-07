using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpenScript : MonoBehaviour
{
    private GameObject InventoryRef;

    public bool inventoryOpened = false;

    void Start()
    {
        InventoryRef = GameObject.Find("InventoryFont");
        InventoryRef.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (!inventoryOpened)
            {
                OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }
    }

    public void OpenInventory()
    {
        InventoryRef.SetActive(true);
        inventoryOpened = true;
    }

    public void CloseInventory()
    {
        InventoryRef.SetActive(false);
        inventoryOpened = false;
    }


}