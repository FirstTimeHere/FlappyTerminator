using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GhostMover))]
[RequireComponent(typeof(ScoreCounter))]
[RequireComponent(typeof(GhostCollisionHandler))]
public class Ghost : MonoBehaviour
{
    private GhostMover _mover;
    private ScoreCounter _scoreCounter;
    private GhostCollisionHandler _handler;

    public event Action GameOver;

    private void Awake()
    {
        _mover = GetComponent<GhostMover>();
        _scoreCounter = GetComponent<ScoreCounter>();
        _handler = GetComponent<GhostCollisionHandler>();
    }
}
