using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoEscada : MonoBehaviour
{
    public Transform destino;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            collision.transform.position = destino.position;
    }
}
