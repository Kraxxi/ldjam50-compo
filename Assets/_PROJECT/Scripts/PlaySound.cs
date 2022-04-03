using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public FloatVar sfxVolume;
    public AudioSource audioSource;
    public List<AudioClip> clips;
    public float minPitch;
    public float maxPitch;

    public float minVolume;
    public float maxVolume;


    public void Play()
    {
        audioSource.clip = clips[Random.Range(0, clips.Count)];
        audioSource.pitch = Random.Range(minPitch, maxPitch) * sfxVolume.value;
        audioSource.volume = Random.Range(minVolume, maxVolume) * sfxVolume.value;
        audioSource.Play();
    }
}
