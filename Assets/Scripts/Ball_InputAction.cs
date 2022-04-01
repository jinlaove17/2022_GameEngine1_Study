using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball_InputAction : MonoBehaviour
{
    private Rigidbody rigidBody = null;

    private Vector3 direction;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue value)
    {
        var rawValue = value.Get<Vector2>();

        direction = new Vector3(rawValue.x, 0.0f, rawValue.y);
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(direction);
    }
}
