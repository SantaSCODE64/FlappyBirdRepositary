using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSignalColl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Signal")
        {
            GameManager.isTriggered = true;
        }
    }
}
