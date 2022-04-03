using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName;
    public SpriteHolder skins;
    public int skinIndex;
    public Image skinImage;


    private void Start()
    {
        skinIndex = PlayerPrefs.GetInt("Skin", 0);
        skinImage.sprite = skins.models[skinIndex];
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void NextSkin()
    {
        if (skinIndex + 1 < skins.models.Count)
        {
            skinIndex = skinIndex + 1;
        }
        else
        {
            skinIndex = 0;
        }
        UpdateSkin();
    }

    public void PrevSkin()
    {
        if (skinIndex - 1 >= 0)
        {
            skinIndex = skinIndex - 1;
        }
        else
        {
            skinIndex = skins.models.Count - 1;
        }
        UpdateSkin();
    }

    public void UpdateSkin()
    {
        PlayerPrefs.SetInt("Skin", skinIndex);
        skinImage.sprite = skins.models[skinIndex];
    }
}
