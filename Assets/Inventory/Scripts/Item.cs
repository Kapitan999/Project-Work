using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName ="Inventory/Item")]

public class Item : ScriptableObject
{
    [Header("Базовые характеристики")]
    public string Name = "";
    public string Description = "Описание предмета";
    public Sprite icon = null;
    public string ObjClass = "";
    public string TypeOfObj = "";
    


    [Header("Оружие")]
    public string CritDamageChance = "";
    public string ExtraCritDamage = "";
    public string Bleeding = "";
    public string Poisoning = "";

    [Header("Броня")]


    [Header("Еда")]
    public int HealingPower = 0;
}

