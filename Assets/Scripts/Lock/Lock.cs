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
    [SerializeField] private Transform _pickupPosition;

    private Vector3 _rotation;
    private Vector3 _code;

    public int cylinderA, cylinderB, cylinderC;

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
        _code = new Vector3(6, 8, 1);
    }


    [ContextMenu("Rotate Disk")]
    public void Rotate(Disks disk)
    {
        int diskId = (int)disk;
        _disks[diskId].transform.Rotate(_rotation);

        switch (disk)
        {
            case Disks.First:
                if (++CylinderA == (int)_code.x)
                {
                    print("CYLIDER A IS RIGHT");
                }
                break;
            case Disks.Second:
                if (++CylinderB == (int)_code.y)
                {
                    print("CYLIDER B IS RIGHT");
                }
                break;
            case Disks.Third:
                if (++CylinderC == (int)_code.z)
                {
                    print("CYLIDER C IS RIGHT");
                }
                break;
        }
    }
}
