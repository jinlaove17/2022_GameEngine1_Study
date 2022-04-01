using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidBody = null;

    private Vector3 direction;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        direction = new Vector3(hor, 0.0f, ver);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction += new Vector3(0.0f, 200.0f, 0.0f);
        }

        if (Input.GetMouseButton(0)) // Left Click
        {
            var pos = Input.mousePosition;
            var cam = FindObjectOfType<Camera>();
            var ray = cam.ScreenPointToRay(pos);

            if (Physics.Raycast(ray, out var hitInfo))
            {
                print(hitInfo.collider.name);
            }
        }
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(direction);
    }
}
