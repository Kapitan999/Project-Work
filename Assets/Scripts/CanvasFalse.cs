using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasFalse : MonoBehaviour
{

  

    public void Visible()
    {
        foreach (Transform child in GetComponentInParent<Transform>())
        {
            GameObject cld = child.gameObject;
            cld.SetActive(true);
        }
    }

    public void UnVisible()
    {
        foreach (Transform child in GetComponentInParent<Transform>())
        {
            GameObject cld = child.gameObject;
            cld.SetActive(false);
        }
    }
}
