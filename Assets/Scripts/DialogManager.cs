using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public CanvasFalse canvasFalse;

    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        //gameObject.SetActive(true);

        nameText.text = dialog.name;
       // Debug.Log(nameText);
        sentences.Clear();
        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentense();
    }


    public void DisplayNextSentense()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
           
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
        //StartCoroutine(TypeSentence(sentence));
    }

   // IEnumerable TypeSentence(string sentence)
   // {
    //    dialogText.text = "";
    //    foreach(char letter in sentence.ToCharArray())
     //   {
     //       dialogText.text += letter;
     //       yield return null;
     //   }
   // }

    public void EndDialog()
    {
        canvasFalse.UnVisible();
        Debug.Log("End");
    }
}
