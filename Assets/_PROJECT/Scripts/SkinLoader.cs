using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public SpriteRenderer sr;
    public SpriteHolder skins;
    
    private void Start()
    {
        sr.sprite = skins.models[PlayerPrefs.GetInt("Skin")];
    }
}
