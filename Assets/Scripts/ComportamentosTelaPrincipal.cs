using UnityEngine;
using UnityEngine.SceneManagement;

public class ComportamentosTelaPrincipal : MonoBehaviour
{
    public void CarregaFase(string nomeScene) => SceneManager.LoadScene(nomeScene);
}
