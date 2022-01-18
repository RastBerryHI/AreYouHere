using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float _xSensitivity;
    [SerializeField] private float _ySensitivity;
    [SerializeField] private float _xClamp;
    [SerializeField] Transform _player;

    private float _mouseX;
    private float _mouseY;
    private float _xRotation = 0f;
    private Vector2 _mouseInput;

    private InputMaster _controls;

    private void Awake()
    {
        _controls = new InputMaster();
        _controls.Player.MouseX.performed += context => _mouseInput.x = context.ReadValue<float>();
        _controls.Player.MouseY.performed += context => _mouseInput.y = context.ReadValue<float>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
       RecieveInput(_mouseInput);
        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -_xClamp, _xClamp);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _player.Rotate(Vector3.up * _mouseX);

    }
    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    public void RecieveInput(Vector2 mouseInput)
    {
        _mouseX = mouseInput.x * _xSensitivity * Time.deltaTime;
        _mouseY = mouseInput.y * _ySensitivity * Time.deltaTime;
    }
}
