using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Ghost _ghost;

    private void OnEnable()
    {
        _ghost.GameOver += StopGame;
    }

    private void OnDisable()
    {
        _ghost.GameOver -= StopGame;
    }

    private void StopGame()
    {
        Time.timeScale = 0;
    }
}
