using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody body;
    public PlayerInput playerControls;
    public float speed = 5f;

    private InputAction move;
    private InputAction fire;

    private Transform cameraTransform;

    Vector2 moveDirection = Vector2.zero;

    private void Awake()
    {
        playerControls = new PlayerInput();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 temp = new Vector3(moveDirection.x, 0f, moveDirection.y);
        temp = cameraTransform.forward * temp.z + cameraTransform.right * temp.x;
        body.velocity = new Vector3(temp.x * speed, body.velocity.y, temp.z * speed);
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();

        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
    }

    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Pew pew");
    }
}
