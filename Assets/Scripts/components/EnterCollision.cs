using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterCollision : MonoBehaviour
{
    [SerializeField]private  string _tag;
    [SerializeField] private EnterEvent _event;

    private void EnterCollision2D(Collision2D other){
        if (other.gameObject.CompareTag(_tag)){
            if (_event != null){
                _event.Invoke(other.gameObject);
            }
        }
    }
    [Serializable]
    public class EnterEvent : UnityEvent<GameObject> {

    }
}
