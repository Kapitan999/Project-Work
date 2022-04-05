using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTriggers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(name + " is triggered with " + collider.name);
    }
}
