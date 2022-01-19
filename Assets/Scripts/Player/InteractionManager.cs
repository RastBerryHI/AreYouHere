using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    private Camera _camera;
    private InputMaster _controls;
    private bool b_isLock;
    private void Awake()
    {
        b_isLock = false;
        _camera = Camera.main;
        _controls = new InputMaster();
        _controls.Player.Interract.performed += context => ShootRay();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void ShootRay()
    {
        RaycastHit HitInfo;
        if (Physics.Raycast(_camera.transform.position, Camera.main.transform.forward, out HitInfo, 3f, _layerMask))
        {
            if (HitInfo.transform.tag == "Lock" && b_isLock == false) 
            {
                GenericEvents.s_instance.onStartPickCode.Invoke();
                Lock lock_ = HitInfo.transform.GetComponent<Lock>();
                if (lock_ != null)
                    GenericEvents.s_instance.onGetCameraPosition.Invoke(lock_.PickupPosition);
                else
                    Debug.LogError("Lock is null");
                b_isLock = true;
            }
            else if(HitInfo.transform.tag == "Lock" && b_isLock == true)
            {
                GenericEvents.s_instance.onEndPickCode.Invoke();
                b_isLock = false;
            }
        }
    }
}
