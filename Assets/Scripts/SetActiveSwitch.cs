using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveSwitch : MonoBehaviour, ISwitch
{
    public bool IsOn() => gameObject.activeSelf;
    public void SetOn(bool status) => gameObject.SetActive(status);
}
