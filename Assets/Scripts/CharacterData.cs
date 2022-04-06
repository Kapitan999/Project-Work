using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    [SerializeField] private Sprite portrait = null;
    public Sprite Portrait => portrait;


    [SerializeField] private string _name = "Неизвестный";
    public string Name => _name;


    [SerializeField] public string text = "Лорем Ипсум итд.";
}
