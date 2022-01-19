using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshController : MonoBehaviour
{
    [SerializeField] private GameObject _armsMesh;
    void Start()
    {
        GenericEvents.s_instance.onStartPickCode.AddListener(DisableArms);
        GenericEvents.s_instance.onEndPickCode.AddListener(EnableArms);
    }

    private void DisableArms()
    {
        _armsMesh.SetActive(false);
    }

    private void EnableArms()
    {
        _armsMesh.SetActive(true);
    }
}
