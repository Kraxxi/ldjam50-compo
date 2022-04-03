using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnSpawn : MonoBehaviour
{
    public FloatVar sfxVolume;
    public AudioSource audioSource;
    public List<AudioClip> clips;
    public float minPitch;
    public float maxPitch;

    public float minVolume;
    public float maxVolume;
    
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clips[Random.Range(0, clips.Count)];
        audioSource.pitch = Random.Range(minPitch, maxPitch);
        audioSource.volume = Random.Range(minVolume, maxVolume) * sfxVolume.value;
        audioSource.Play();
    }
}
