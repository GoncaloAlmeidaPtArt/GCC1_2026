using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private string moveInput = "Move";
    [SerializeField] private Transform model;
    
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

        if (_direction.x > 0)
            {
            _controller.linearVelocity = (transform.forward*speed*Time.fixedDeltaTime);
            model.rotation = Quaternion.Euler(0,-90,0);
            }
        else if (_direction.x < 0)
        {
            _controller.linearVelocity = (-transform.forward*speed*Time.fixedDeltaTime);
            model.rotation = Quaternion.Euler(0,90,0);
        }
        else
            _controller.linearVelocity = Vector3.zero;
    }
}
