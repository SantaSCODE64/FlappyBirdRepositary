using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDestroying : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        GameManager.Instance.pillarsList.Remove(collision.gameObject);
    }

}
