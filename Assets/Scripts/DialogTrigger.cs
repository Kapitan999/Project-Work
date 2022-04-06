using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public CanvasFalse canvasFalse;

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                canvasFalse.Visible();
                TriggerDialog();
            }
            
        }
    }

    

}
