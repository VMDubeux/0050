using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private InputAction _axis;

    public Controls Control;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;

        Control = new Controls();
        _axis = Control.Input.Axis;
        Control.Enable();
    }

    public Vector3 GetAxis() 
    {
        return new Vector3(_axis.ReadValue<Vector2>().x, 0, _axis.ReadValue<Vector2>().y);
    }
}
