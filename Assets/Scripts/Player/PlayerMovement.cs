using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;

    private bool b_isGrounded;
    private CharacterController _controller;
    private InputMaster _controls;

    private Vector3 _direction;
    private Vector3 _currentDirection;
    private Vector3 velocity;
    private void Awake()
    {
        _controls = new InputMaster();
        _controller = GetComponent<CharacterController>();
        _controls.Player.Movement.performed += context =>  Move(context.ReadValue<Vector2>());
        _controls.Player.Movement.canceled += context => StopMove();
    }

    private void Update()
    {
        b_isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);

        if (b_isGrounded == true && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        _direction = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * new Vector3(_currentDirection.x, 0, _currentDirection.y);
        _controller.Move(_direction * _moveSpeed * Time.deltaTime);

        velocity.y += -9.81f * Time.deltaTime;
        _controller.Move(velocity * Time.deltaTime);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Move(Vector2 direction)
    {
        _currentDirection = direction;
    }

    private void StopMove()
    {
        _currentDirection = Vector2.zero;
    }
}
