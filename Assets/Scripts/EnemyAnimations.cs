using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _anim;
    private Controller _controller;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponentInParent<Controller>();
    }

    void Update()
    {
        _anim.SetFloat("Blend", _controller.Velocity);
    }
}
