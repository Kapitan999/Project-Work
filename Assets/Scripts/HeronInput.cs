using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeronInput : MonoBehaviour
{
    [SerializeField] private HeroMain _hero;

    

    public void Movement (InputAction.CallbackContext context){
        Vector2 direction = context.ReadValue<Vector2>();
        _hero.SetDirection(direction);
    }
}
