using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimationManager s_instance;

    private Animator _anim;
    private InputMaster _controls;

    private bool b_isEquiped = false;
    private bool b_isWalkieEnabled = false;

    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Destroy(s_instance.gameObject);
        }
        _anim = GetComponent<Animator>();
        _controls = new InputMaster();
        _controls.Player.TakeFlashlight.performed += context => TakeFlashlight();
        _controls.Player.TakeWalkie.performed += context => TakeWalkie();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }


    public event UnityAction onWalkieEnabled;
    public event UnityAction onWalkieDisabled;

    private void TakeFlashlight()
    {
        b_isEquiped = !b_isEquiped;
        _anim.SetBool("isFlashlight", b_isEquiped);
    }

    private void TakeWalkie()
    {
        b_isEquiped = !b_isEquiped;
        _anim.SetBool("isWalkie", b_isEquiped);
        StartCoroutine(DelayRemoveWalkie());
    }

    private void ToggleWalkie()
    {
        if (b_isWalkieEnabled == false)
        {
            onWalkieEnabled.Invoke();
            b_isWalkieEnabled = !b_isWalkieEnabled;
        }
        else if (b_isWalkieEnabled == true)
        {
            onWalkieDisabled.Invoke();
            b_isWalkieEnabled = !b_isWalkieEnabled;
        }
    }

    private IEnumerator DelayRemoveWalkie()
    {
        yield return new WaitForSeconds(0.05f);
        b_isEquiped = !b_isEquiped;
        _anim.SetBool("isWalkie", false);
    }
}
