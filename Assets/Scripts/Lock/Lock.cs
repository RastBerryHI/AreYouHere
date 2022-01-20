using UnityEngine;

public enum Disks : sbyte
{
    First,
    Second,
    Third
}

public class Lock : MonoBehaviour
{
    [SerializeField] private Transform[] _disks;
    [SerializeField] private Transform _handle;
    [SerializeField] private Transform _pickupPosition;

    private Vector3 _handleRot;
    private Vector3 _rotation;
    private Vector3 _code;


    private int cylinderA, cylinderB, cylinderC;
    private bool b_iscylinderA, b_iscylinderB, b_iscylinderC;

    public Transform PickupPosition
    {
        get => _pickupPosition;
    }

    private int CylinderA
    {
        get => cylinderA;
        set
        {
            if(value > 9)
            {
                cylinderA = 0;
            }
            else
            {
                cylinderA = value;
            }
        }
    }

    private int CylinderB
    {
        get => cylinderB;
        set
        {
            if (value > 9)
            {
                cylinderB = 0;
            }
            else
            {
                cylinderB = value;
            }
        }
    }

    private int CylinderC
    {
        get => cylinderC;
        set
        {
            if (value > 9)
            {
                cylinderC = 0;
            }
            else
            {
                cylinderC = value;
            }
        }
    }

    private void Awake()
    {
        _rotation = new Vector3(0, 36, 0);
        _handleRot = new Vector3(50, 0, 0);
        _code = new Vector3(6, 8, 1);
    }

    private void Start()
    {
        GenericEvents.s_instance.onSuccessPickCode.AddListener(OpenLock);
    }

    private void OpenLock()
    {
        transform.gameObject.AddComponent<Rigidbody>();
        _handle.Rotate(_handleRot);
        Destroy(gameObject, 15f);
    }

    [ContextMenu("Rotate Disk")]
    public void Rotate(Disks disk)
    {
        int diskId = (int)disk;
        _disks[diskId].transform.Rotate(_rotation);
        print("Rotating");
        switch (disk)
        {
            case Disks.First:
                if (++CylinderA == (int)_code.x)
                {
                    b_iscylinderA = true;
                }
                else
                {
                    b_iscylinderA = false;
                }
                break;
            case Disks.Second:
                if (++CylinderB == (int)_code.y)
                {
                    b_iscylinderB = true;
                }
                else
                {
                    b_iscylinderB = false;
                }
                break;
            case Disks.Third:
                if (++CylinderC == (int)_code.z)
                {
                    b_iscylinderC = true;
                }
                else
                {
                    b_iscylinderC = false;
                }
                break;
        }

        if(b_iscylinderA == true && b_iscylinderB == true && b_iscylinderC == true)
        {
            GenericEvents.s_instance.onSuccessPickCode.Invoke();
            GenericEvents.s_instance.onEndPickCode.Invoke();
        }
    }
}
