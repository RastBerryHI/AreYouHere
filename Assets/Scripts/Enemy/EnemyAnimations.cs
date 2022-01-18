using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    [SerializeField] private GameObject _enemyMesh;
    private Animator _anim;
    private Controller _controller;
    private bool b_isBlinked = true;
    private bool b_isEnabled = true;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponentInParent<Controller>();
    }

    private void Start()
    {
        StartCoroutine(VisuilizeEnemy());
    }

    private IEnumerator PlayBlink()
    {
        b_isBlinked = false;
        float delay = Random.Range(0.1f, 1f);

        yield return new WaitForSeconds(delay);
        b_isBlinked = true;
        b_isEnabled = !b_isEnabled;
        _enemyMesh.gameObject.SetActive(b_isEnabled);
    }

    private IEnumerator<WaitForSeconds> VisuilizeEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            _anim.SetFloat("Blend", _controller.Velocity);

            if ((EnemyBenavior.s_instance.State == BehaviorStates.Chase || EnemyBenavior.s_instance.State == BehaviorStates.Search) && b_isBlinked == true)
            {
                StartCoroutine(PlayBlink());
            }
        }
    }
}
