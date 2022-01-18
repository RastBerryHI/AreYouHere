using UnityEngine.Events;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    [SerializeField] private GameObject _flashLight;
    [SerializeField] private GameObject _walkie;

    public void EnableFlashlight()
    {
        _flashLight.SetActive(true);
    }

    public void RemoveFlashlight()
    {
        _flashLight.SetActive(false);
        _walkie.SetActive(false);
    }

    public void EnableWalkie()
    {
        _walkie.SetActive(true) ;
    }
}
