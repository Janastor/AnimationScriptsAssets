using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _transform;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
    }
    
    void Update()
    {
        _transform.Rotate(0,  _speed * Time.deltaTime, 0);
    }
}
