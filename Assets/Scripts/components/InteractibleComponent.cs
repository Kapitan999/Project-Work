using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractibleComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;

    public void Interacting(){
        if (_action!= null){
            _action.Invoke();
        }
    }
}
