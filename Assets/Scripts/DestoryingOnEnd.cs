using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryingOnEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EndColl")
        {
            Destroy(collision.gameObject);
        }
    }
}
