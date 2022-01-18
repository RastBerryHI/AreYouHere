using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator _anim;
    private InputMaster _controls;

    private bool b_isEquiped = false;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _controls = new InputMaster();
        _controls.Player.TakeFlashlight.performed += context => TakeFlashlight();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void TakeFlashlight()
    {
        b_isEquiped = !b_isEquiped;
        _anim.SetBool("isFlashlight", b_isEquiped);
    }
}
