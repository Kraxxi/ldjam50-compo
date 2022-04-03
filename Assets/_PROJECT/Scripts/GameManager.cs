using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private Killable playerKillable;

    private void Start()
    {
        GameState.enemiesKilled = 0;
        GameState.survivedTime = 0;
        
        GameObject player = GameObject.FindWithTag("Player");

        playerKillable = player.GetComponent<Killable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerKillable && playerKillable.isAlive)
        {
            scoreText.text = $"{Time.timeSinceLevelLoad:F}s";
        }
    }
}
