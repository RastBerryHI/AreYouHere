using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    private Camera _camera;
    private InputMaster _controls;
    private Vector2 _mousePos;
    [SerializeField] private bool b_isLock;
    [SerializeField] private Lock _currentLock;
    private void Awake()
    {
        b_isLock = false;
        _camera = Camera.main;
        _controls = new InputMaster();
        _controls.Player.Interract.performed += context => ShootRay();
        _controls.Player.MouseL.performed += context => HandleMouseClick();
        _controls.Player.MouseDrag.performed += context => GetMousePosition(context.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void HandleMouseClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(_mousePos);
        RaycastHit HitInfo;
        print("Click");
        if(Physics.Raycast(ray, out HitInfo, 3f, _layerMask) && _currentLock != null)
        {
            switch (HitInfo.transform.tag)
            {
                case "CylinderA":
                    print("Start unlocking");
                    _currentLock.Rotate(Disks.First);
                    break;
                case "CylinderB":
                    print("Start unlocking");
                    _currentLock.Rotate(Disks.Second);
                    break;
                case "CylinderC":
                    print("Start unlocking");
                    _currentLock.Rotate(Disks.Third);
                    break;
            }
        }
    }

    private void GetMousePosition(Vector2 mousePos)
    {
        _mousePos = mousePos;
    }

    private void ShootRay()
    {
        RaycastHit HitInfo;
        if (Physics.Raycast(_camera.transform.position, Camera.main.transform.forward, out HitInfo, 3f, _layerMask))
        {
            if (HitInfo.transform.tag == "Lock" && b_isLock == false) 
            {
                GenericEvents.s_instance.onStartPickCode.Invoke();
                _currentLock = HitInfo.transform.GetComponent<Lock>();
                if (_currentLock != null)
                    GenericEvents.s_instance.onGetCameraPosition.Invoke(_currentLock.PickupPosition);
                else
                    Debug.LogError("Lock is null");
                b_isLock = true;
            }
            else if(HitInfo.transform.tag == "Lock" && b_isLock == true)
            {
                GenericEvents.s_instance.onEndPickCode.Invoke();
                _currentLock = null;
                b_isLock = false;
            }
        }
    }
}
