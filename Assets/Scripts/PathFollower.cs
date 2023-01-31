using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

[RequireComponent(typeof(Rigidbody))]
public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private PathCreator _pathCreator;
    
    private float _distanceTravelled;

    private Rigidbody _rigidbody;

    private void Start()
    { 
        _rigidbody = GetComponent<Rigidbody>();
        
        _rigidbody.MovePosition(_pathCreator.path.GetPointAtDistance(_distanceTravelled));
    }

    private void Update()
    {
        
    }
}
