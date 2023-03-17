using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Touch _touch;
    private Vector3 _position;

    [SerializeField] private float speed;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                TransformPosition();
            }
        }
    }

    private Vector3 TransformPosition()
    {
        transform.position = _position;
           _position = new Vector3(transform.position.x + _touch.deltaPosition.x * speed,
            transform.position.y,
            transform.position.z + _touch.deltaPosition.y * speed);

           return _position;
    }
}
