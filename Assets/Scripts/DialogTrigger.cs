using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public CanvasFalse canvasFalse;
    public CanvasFalse2 canvasFalse2;
    public HeroMain heroMain;
    public int flag = 1;
    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
            Debug.Log("YES");
            canvasFalse2.Visible();
            if (Input.GetKeyDown(KeyCode.E))
            {
                flag = 0;
                canvasFalse.Visible();
                TriggerDialog();
            }

    }


}
