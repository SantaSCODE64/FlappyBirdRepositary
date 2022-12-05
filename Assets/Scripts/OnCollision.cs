using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    public static OnCollision Instance { get; private set; }
    public bool isCollided = false;
    public bool isOut = false;

    private void Awake()
    {
        Instance = this;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        PillarsMoving.Instance.movingSpeed = 0;
        MoveUp.Instance.movingUpSpeed = 0;
        isCollided = true;
              
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DownStopper")
        {
            isOut = true;
        }
    }
}
