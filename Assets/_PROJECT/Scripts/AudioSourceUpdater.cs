using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceUpdater : MonoBehaviour
{
    public FloatVar volumeSetting;
    public AudioSource volumeSource;

    private void Start()
    {
        volumeSetting.value = PlayerPrefs.GetFloat(volumeSetting.varName, 0.25f);
        
    }

    public void UpdateVolume()
    {
        volumeSource.volume = volumeSetting.value;
    }

    
    //This should be event based, and not run every frame
    private void Update()
    {
        UpdateVolume();
    }
}
