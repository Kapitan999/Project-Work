using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeronInput : MonoBehaviour
{
    [SerializeField] private HeroMain _hero;
    public DialogTrigger dialogTrigger;
    PlayerInput playerInput;

    private void Start()
    {
        playerInput = gameObject.GetComponent<PlayerInput>();
    }


    private void Update()
    {
        if(dialogTrigger.flag == 0)
        {
            playerInput.enabled = false;
        }
        else
        {
            playerInput.enabled = true;
        }
    }
    public void Movement(InputAction.CallbackContext context) {
            
            playerInput.enabled = true;
            Vector2 direction = context.ReadValue<Vector2>();
            _hero.SetDirection(direction);

    }
}
