using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatSettingApplier : MonoBehaviour
{
    public FloatVar settingVar;
    public Slider slider;

    private void OnEnable()
    {
        slider.value = settingVar.value;
    }

    public void UpdateFloatSetting(float val)
    {
        settingVar.value = val;
        PlayerPrefs.SetFloat(settingVar.varName, settingVar.value);
    }
}
