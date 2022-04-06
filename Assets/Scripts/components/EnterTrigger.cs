using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private UnityEvent _action;

// метод, который определяет пересечение коллайдеров
    private void EnterTrigger2D(Collider2D other){
        if (other.gameObject.CompareTag(_tag)){
            if (_action!= null){
            _action.Invoke();
            }
        }

    }
}
