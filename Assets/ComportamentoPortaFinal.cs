using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoPortaFinal : MonoBehaviour
{
    public string nomeProximaFase= "Creditos";
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine("MudaParaTelaFinal", GetComponent<AudioSource>().clip.length);
        }
    }
    IEnumerator MudaParaTelaFinal(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeProximaFase);
    }
}
