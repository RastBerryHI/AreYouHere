using System.Collections.Generic;
using UnityEngine;

public class WalkieAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] _ghostWhimps;
    [SerializeField] private AudioSource _audioVoice;
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
        _audioVoice.enabled = false;
        StartCoroutine(FindTargetsWithDelay(0.1f));
    }

    private IEnumerator<WaitForSeconds> FindTargetsWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            float distance = Vector3.Distance(transform.position, EnemyBenavior.s_instance.transform.position);

            print(_audioVoice.isPlaying);

            if (distance >= 20)
            {
                _audio.volume = 0.1f;
                _audioVoice.volume = 0;
            }
            else if(distance < 20 && distance >= 15)
            {
                _audio.volume = 0.3f;
                _audioVoice.volume = 0.01f;
                if (_audioVoice.isPlaying == false)
                {
                    _audioVoice.PlayOneShot(_ghostWhimps[Random.Range(0, _ghostWhimps.Length - 1)]);
                }
            }
            else if(distance < 15 && distance >= 10)
            {
                _audio.volume = 0.5f;
                _audioVoice.volume = 0.05f;
                if (_audioVoice.isPlaying == false)
                {
                    _audioVoice.PlayOneShot(_ghostWhimps[Random.Range(0, _ghostWhimps.Length - 1)]);
                }
            }
            else if(distance < 10 && distance >= 5f)
            {
                _audio.volume = 0.7f;
                _audioVoice.volume = 0.1f;
                if (_audioVoice.isPlaying == false)
                {
                    _audioVoice.PlayOneShot(_ghostWhimps[Random.Range(0, _ghostWhimps.Length - 1)]);
                }
            }
            else if(distance < 5 && distance >= 3)
            {
                _audio.volume = 0.85f;
                _audioVoice.volume = 0.3f;

                if (_audioVoice.isPlaying == false)
                {
                    _audioVoice.PlayOneShot(_ghostWhimps[Random.Range(0, _ghostWhimps.Length - 1)]);
                }
            }
            else if(distance < 3)
            {
                _audio.volume = 1f;
                _audioVoice.volume = 0.5f;

                if (_audioVoice.isPlaying == false)
                {
                    _audioVoice.PlayOneShot(_ghostWhimps[Random.Range(0, _ghostWhimps.Length - 1)]);
                }
            }
        }
    }

    private void EnableAudio()
    {
        _audio.enabled = true;
        _audioVoice.enabled = true;
    }

    private void DisableAudio()
    {
        _audio.enabled = false;
        _audioVoice.enabled = false;
    }
}
