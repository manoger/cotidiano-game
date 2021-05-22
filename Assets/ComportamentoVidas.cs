using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComportamentoVidas : MonoBehaviour
{
    public Player player;
    private int vidasAnterior;
    // Start is called before the first frame update
    void Start()
    {
        vidasAnterior = player.vidas;
        GetComponent<Text>().text = $"{vidasAnterior} x";
    }

    // Update is called once per frame
    void Update()
    {
        if(player.vidas != vidasAnterior)
        {
            vidasAnterior = player.vidas;
            GetComponent<Text>().text = $"{vidasAnterior} x";
        }
    }
}
