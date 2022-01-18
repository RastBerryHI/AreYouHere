using System.Collections.Generic;
using UnityEngine;

public class WalkieAudioManager : MonoBehaviour
{
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        AnimationManager.s_instance.onWalkieEnabled += EnableAudio;
        AnimationManager.s_instance.onWalkieDisabled += DisableAudio;
        _audio.enabled = false;

        StartCoroutine(FindTargetsWithDelay(0.2f));
    }

    private IEnumerator<WaitForSeconds> FindTargetsWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            float distance = Vector3.Distance(transform.position, EnemyBenavior.s_instance.transform.position);
            if (distance >= 20)
            {
                print(" distance >= 20 " + distance);
                _audio.volume = 0.1f;
            }
            else if(distance < 20 && distance >= 15)
            {
                print(" distance < 20 && distance <= 15 " + distance);
                _audio.volume = 0.2f;
            }
            else if(distance < 15 && distance >= 10)
            {
                print(" distance < 15 && distance <= 10 " + distance);
                _audio.volume = 0.3f;
            }
            else if(distance < 10 && distance >= 5f)
            {
                print(" distance < 10 && distance <= 5f " + distance);
                _audio.volume = 0.5f;
            }
            else if(distance < 5 && distance >= 3)
            {
                print(" distance < 5 && distance <= 3 " + distance);
                _audio.volume = 0.7f;
            }
            else if(distance < 3)
            {
                _audio.volume = 1f;
            }

        }
    }

    private void EnableAudio()
    {
        _audio.enabled = true;
    }

    private void DisableAudio()
    {
        _audio.enabled = false;
    }
}
