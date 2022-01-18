using UnityEngine.Events;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    [SerializeField] private GameObject _flashLight;
    public static Equipment s_instance;
    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
    }

    public void EnableFlashlight()
    {
        print("Enable");
        _flashLight.SetActive(true);
    }

    public void RemoveFlashlight()
    {
        print("Disable");
        _flashLight.SetActive(false);
    }
}
