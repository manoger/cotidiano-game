using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoPapel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().color = Color.yellow;
            Destroy(gameObject, 1f);
        }
    }
}
