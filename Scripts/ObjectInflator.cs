using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class ObjectInflator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _transform;
    private Vector3 _defaultScale;
    private KeyCode _resetKey = KeyCode.R;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
        _defaultScale = transform.localScale;
    }
    
    void Update()
    {
        _transform.localScale += Vector3.one * _speed * Time.deltaTime;
        
        if (Input.GetKeyDown(_resetKey))
            _transform.localScale = _defaultScale;
    }
}
