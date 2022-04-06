using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour, ISwitch
{
    //[SerializeField] private string OnTrigger = "True";
    //[SerializeField] private string OffTrigger = "False";

    private bool isOn = false;
    private Animator animator = null;


    void Start() => animator = gameObject.GetComponent<Animator>();


    public bool IsOn() => isOn;


    public void SetOn(bool status)
    {
        if(status == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);

        }
    }
}
