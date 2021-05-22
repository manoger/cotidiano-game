using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoInimigo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}
