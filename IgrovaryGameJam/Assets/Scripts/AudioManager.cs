using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    public AudioClip bgMusic;
    public AudioClip Jump;
    public AudioClip Walk;
    public AudioClip ButtonOn;
    public AudioClip ButtonOff;
    public AudioClip Dash;

    void Start() {
        musicSource.clip = bgMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip) {
        SFXSource.PlayOneShot(clip);
    }
}
