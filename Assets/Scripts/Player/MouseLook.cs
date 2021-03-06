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
    private Vector3 _baseLookPosition;

    private InputMaster _controls;
    private bool b_isMouseLook;

    private void Awake()
    {
        b_isMouseLook = true;
        _controls = new InputMaster();
        _controls.Player.MouseX.performed += context => _mouseInput.x = context.ReadValue<float>();
        _controls.Player.MouseY.performed += context => _mouseInput.y = context.ReadValue<float>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        GenericEvents.s_instance.onGetCameraPosition.AddListener(LookAtLock);

        GenericEvents.s_instance.onStartPickCode.AddListener(ChangeAllowment);
        GenericEvents.s_instance.onStartPickCode.AddListener(EnableCursor);

        GenericEvents.s_instance.onEndPickCode.AddListener(ChangeAllowment);
        GenericEvents.s_instance.onEndPickCode.AddListener(DisableCursor);
        GenericEvents.s_instance.onEndPickCode.AddListener(ReturnToBaseLook);
    }

    private void Update()
    {
        if (b_isMouseLook == false) return;
        RecieveInput(_mouseInput);
        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -_xClamp, _xClamp);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _player.Rotate(Vector3.up * _mouseX);

    }

    private void LookAtLock(Transform t)
    {
        _baseLookPosition = Camera.main.transform.position;
        Camera.main.transform.position = t.position;
        Camera.main.transform.rotation = t.rotation;
    }

    private void ReturnToBaseLook()
    {
        Camera.main.transform.position = _baseLookPosition;
    }

    private void EnableCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void DisableCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void ChangeAllowment()
    {
        b_isMouseLook = !b_isMouseLook;
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
