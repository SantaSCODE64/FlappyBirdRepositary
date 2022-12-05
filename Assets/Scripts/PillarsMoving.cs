using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarsMoving : MonoBehaviour
{
    public static PillarsMoving Instance { get; private set; }
    Vector2 _currentPosition;
    public float movingSpeed = 1;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        _currentPosition = transform.position;
    }

    void Update()
    {
            _currentPosition = transform.position;
            transform.position = new Vector2(_currentPosition.x - movingSpeed, transform.position.y);  
    }
}
