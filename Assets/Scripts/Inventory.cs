using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string name = "";
        public int count = 0;
        public override string ToString()
        {
            return count + " x " + name + ";";
        }
    }


    [SerializeField] private List<Item> itemList = null;


    public void Add(string itemName, int amount = 1)
    {
        if (amount < 0)
        {
            TryRemove(name, -amount);
        }
        else
        {
            foreach (var item in itemList)
            {
                if (item.name == itemName)
                {
                    item.count += amount;
                    return;
                }
            }
            itemList.Add(new Item { name = itemName, count = amount });
        }
    }

    public int Count(string itemName)
    {
        foreach (var item in itemList)
        {
            if (item.name == itemName)
            {
                return item.count;
            }
        }
        return 0;
    }

    public int RemoveAll(string itemName)
    {
        var t = 0;
        foreach (var item in itemList)
        {
            if (item.name == itemName)
            {
                t = item.count;
                item.count = 0;
            }
        }
        return t;
    }

    public bool TryRemove (string itemName, int amount = 1)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].name == itemName)
            {
                if (itemList[i].count == amount)
                {
                    itemList.RemoveAt(i);
                    return true;
                }
                else if (itemList[i].count > amount)
                {
                    itemList[i].count -= amount;
                    return true;
                } else
                {
                    return false;
                }
            }
        }
        return false;
    }

    public bool TryTransfer(string name, Inventory TargetInventory, int amount = 1)
    {
        if (TryRemove(name, amount))
        {
            TargetInventory.Add(name, amount);
            return true;
        }
        else
        {
            return false;
        }
    }
}
