using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoArmarioQueTomba : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            GetComponent<Animator>().SetTrigger("Cair");
    }
    public void TocaSomDeQueda()//animation event
    {
        GetComponent<AudioSource>().Play();
    }
}
