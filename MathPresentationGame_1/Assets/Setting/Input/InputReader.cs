using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

[CreateAssetMenu(menuName ="SO/InputReader")]
public class InputReader : ScriptableObject, IPlayerActions
{
    private Controls _controls;

    public Vector2 Movement { get; private set; }

    private void OnEnable()
    {
        if (_controls == null)
        {   
            _controls = new Controls();
        }
        _controls.Player.SetCallbacks(this);
        _controls.Player.Enable();
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }
}
