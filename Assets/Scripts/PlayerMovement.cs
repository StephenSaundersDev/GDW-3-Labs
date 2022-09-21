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

    Vector2 moveDirection = Vector2.zero;

    private void Awake()
    {
        playerControls = new PlayerInput();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector3(moveDirection.x * speed, 0, moveDirection.y * speed);
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
