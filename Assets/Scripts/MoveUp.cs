using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public static MoveUp Instance { get; private set; }
    public float movingUpSpeed = 4f;
    Rigidbody2D rb;
    public Rigidbody2D rb2;
    bool isReady = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2.gravityScale = 0;
        Invoke("SettingStart", 0.5f);
    }

    void SettingStart()
    {
        isReady = true;
        rb2.gravityScale = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && movingUpSpeed != 0 && isReady)
        {
            rb.velocity = Vector2.up * movingUpSpeed;
        }
    }
}
