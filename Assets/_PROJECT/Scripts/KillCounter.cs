using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public void AddKill()
    {
        GameState.enemiesKilled++;
    }
}
