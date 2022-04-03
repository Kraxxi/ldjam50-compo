using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float horizotalSpeed;
    public float verticalSpeed;

    public Vector2 inputVector;

    public void Move(InputAction.CallbackContext ctx)
    {
        inputVector = ctx.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (inputVector != Vector2.zero)
        {
            inputVector.Normalize();
            transform.Translate(new Vector3(inputVector.x * horizotalSpeed, inputVector.y * verticalSpeed, 0) * Time.fixedDeltaTime);
        }
    }
}
