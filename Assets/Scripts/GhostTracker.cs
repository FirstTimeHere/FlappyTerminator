using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GhostTracker : MonoBehaviour
{
    [SerializeField] private Ghost _ghost;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        var position = transform.position;
        position.x = _ghost.transform.position.x + _offsetX;
        transform.position = position;
    }
}
