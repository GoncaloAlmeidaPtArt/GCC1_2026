using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private string moveInput = "Move";
    
    private float _velocity;
    private Vector2 _direction;
    private Rigidbody _controller;
    private InputAction _move;

    private void Start()
    {
        _controller = GetComponent<Rigidbody>();

        _move = InputSystem.actions.FindAction(moveInput);
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        _direction = _move.ReadValue<Vector2>();

        if (_direction.y > 0)
            _controller.linearVelocity = (transform.forward*speed*Time.fixedDeltaTime);
        else if (_direction.y < 0)
            _controller.linearVelocity = (-transform.forward*speed*Time.fixedDeltaTime);
    }
}
