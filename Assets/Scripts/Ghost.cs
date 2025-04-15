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
        _handler = GetComponent<GhostCollisionHandler>();
        _mover = GetComponent<GhostMover>();
        _scoreCounter = GetComponent<ScoreCounter>();
    }

    private void OnEnable()
    {
        _handler.CollisionDetected += ProcessCollision;
    }

    private void OnDisable()
    {
        _handler.CollisionDetected -= ProcessCollision;
    }


    private void ProcessCollision(IInteractable interactable)
    {
        if (interactable is LaserWeapon)
        {
            GameOver?.Invoke();
        }
    }

    public void Reset()
    {
        _scoreCounter.Reset();
        _mover.Reset();
    }
}
