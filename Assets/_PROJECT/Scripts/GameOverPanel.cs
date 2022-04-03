using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    private void OnEnable()
    {
        GameState.survivedTime = Time.timeSinceLevelLoad;
        gameOverText.text = $"You survived for {GameState.survivedTime:F} seconds and killed {GameState.enemiesKilled} enemies.";
    }
}
