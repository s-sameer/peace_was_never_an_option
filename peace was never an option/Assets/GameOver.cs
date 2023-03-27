using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void OnEnable()
    {
        // Reset the timescale when the game over canvas is shown
        Time.timeScale = 1f;
    }
}
