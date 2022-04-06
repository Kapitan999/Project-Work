using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISwitch
{
    bool IsOn();
    void SetOn(bool status);
}