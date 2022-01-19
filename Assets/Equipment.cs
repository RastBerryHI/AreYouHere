using UnityEngine.Events;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    [SerializeField] private GameObject _flashLight;
    [SerializeField] private GameObject _walkie;

    private bool b_isFlashlightActive;


    void Start()
    {
        GenericEvents.s_instance.onStartPickCode.AddListener(RemoveFlashlight);
        GenericEvents.s_instance.onEndPickCode.AddListener(ReturnEquipment);
    }

    public void EnableFlashlight()
    {
        _flashLight.SetActive(true);
    }

    public void RemoveFlashlight()
    {
        b_isFlashlightActive = _flashLight.activeSelf;

        _flashLight.SetActive(false);
        _walkie.SetActive(false);
    }

    public void EnableWalkie()
    {
        _walkie.SetActive(true);
    }

    public void ReturnEquipment()
    {
        if(b_isFlashlightActive == true)
        {
            _flashLight.SetActive(true);
        }
    }
}
