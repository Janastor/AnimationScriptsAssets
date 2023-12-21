using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _transform;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
    }
    
    void Update()
    {
        _transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime), Space.Self);
    }
}
