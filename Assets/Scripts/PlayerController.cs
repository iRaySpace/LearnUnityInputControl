using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 270f;

    private Rigidbody rb;
    private PlayerControls playerControls;
    private Vector3 movementDirection;
    private bool hasJumped;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        playerControls = new PlayerControls();
        playerControls.LandAction.Enable();
        playerControls.LandAction.Jump.performed += ctx => {
            HandleJump();
        };
    }

    private void HandleJump()
    {
        hasJumped = true;
    }

    private void Update()
    {
        Vector2 inputVector = playerControls.LandAction.Movement.ReadValue<Vector2>();
        movementDirection = new Vector3(inputVector.x, 0f, inputVector.y);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(movementDirection * speed * Time.deltaTime, ForceMode.VelocityChange);
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (hasJumped)
        {
            rb.AddForce(transform.up * 10f, ForceMode.Impulse);
            hasJumped = false;
        }
    }
}
