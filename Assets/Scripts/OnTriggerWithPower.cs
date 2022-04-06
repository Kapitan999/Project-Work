using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerWithPower : MonoBehaviour
{
    SpriteRenderer rend;


    void Awake()
    {
        //gameObject.SetActive(false);
        rend = this.gameObject.GetComponent<SpriteRenderer>(); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            //gameObject.SetActive(true);
            rend.enabled = enabled;
        }
    }

}
