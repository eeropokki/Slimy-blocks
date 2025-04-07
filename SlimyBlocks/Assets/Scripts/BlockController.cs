using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlockController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 90f;

    private PlayerInputActions inputActions;
    private float moveInput;

    private void Awake()
    {
        inputActions = new PlayerInputActions();

        // Listen moving (A/D or <LeftArrow/RightArrow)
        inputActions.Gameplay.Move.performed += ctx => moveInput = ctx.ReadValue<float>();
        inputActions.Gameplay.Move.canceled += ctx => moveInput = 0f;

        // Listen rotating (W or UpArrow)
        inputActions.Gameplay.Rotate.performed += ctx => RotateBlock();
    }

    private void OnEnable()
    {
        inputActions.Gameplay.Enable();
    }

    private void OnDisable()
    {
        inputActions.Gameplay.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates block horizontally
        Vector3 move = new Vector3(moveInput, 0f, 0f);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
    private void RotateBlock()
    {
        // Rotates block 90 degrees on the z-axis
        transform.Rotate(0f, 0f, rotateSpeed);
    }
}

public class BlockDrop : MonoBehaviour
{
    public float fallSpeed = 2f; // Falling speed

    void Update()
    {
        // Block falls down
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // Check if block goes too far down
        if (transform.position.y <= 0.5f)
        {
            // Lock the block
            enabled = false;
        }
    }
}
