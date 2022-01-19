using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private float _sprintingMultiplier;
    [SerializeField] private LayerMask _groundMask;

    private bool b_isGrounded;
    private bool b_isMovementAllowed;

    private CharacterController _controller;
    private InputMaster _controls;

    private Vector3 _direction;
    private Vector3 _currentDirection;
    private Vector3 velocity;

    private float _sprintSpeed;
    private float _baseSpeed;
    private void Awake()
    {
        b_isMovementAllowed = true;
        _controls = new InputMaster();
        _controller = GetComponent<CharacterController>();

        _controls.Player.Movement.performed += context =>  Move(context.ReadValue<Vector2>());
        _controls.Player.Movement.canceled += context => StopMove();

        _controls.Player.Sprint.performed += context => Sprint();
        _controls.Player.Sprint.canceled += context => StopSprint();

        _controls.Player.Crouch.performed += context => Crouch();
        _controls.Player.Crouch.canceled += context => StopCrouch();

        GenericEvents.s_instance.onStartPickCode.AddListener(ChangeAllowment);
        GenericEvents.s_instance.onEndPickCode.AddListener(ChangeAllowment);
    }

    private void Start()
    {
        _baseSpeed = _moveSpeed;
        _sprintSpeed = _moveSpeed * _sprintingMultiplier;
    }

    private void Update()
    {
        if (b_isMovementAllowed == false) return;

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

    private void ChangeAllowment()
    {
        b_isMovementAllowed = !b_isMovementAllowed;
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Sprint()
    {
        _moveSpeed = _sprintSpeed;
    }

    private void StopSprint()
    {
        _moveSpeed = _baseSpeed;
    }

    private void Crouch()
    {
        _controller.height /= 2;
    }

    private void StopCrouch()
    {
        _controller.height *= 2;
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
