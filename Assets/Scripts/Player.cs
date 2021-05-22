using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource SomDeDano;
    public Animator animator;
    public float velocidade;
    public float forcaPulo;
    public bool verificaChao;
    public float delayComDano;
    public int vidas = 5;
    public Transform chaoVerificador;

    void Update() => Movimentacao();


    void Movimentacao()
    {
        verificaChao = Physics2D.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Chao"));


        if (Input.GetAxisRaw("Horizontal") > 0)
        {    
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

        if (Input.GetButtonDown("Jump") && verificaChao)
            GetComponent<Rigidbody2D>().AddForce(transform.up * forcaPulo);

        if (Input.GetAxisRaw("Horizontal") == 0)
            animator.SetBool("emMovimento", false);
        else
            animator.SetBool("emMovimento", true);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (vidas > 0)
                StartCoroutine("ReceberDano", collision);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    

    IEnumerator ReceberDano(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
        tag = "Untagged";
        collision.collider.isTrigger = true;
        SomDeDano.Play();
        vidas--;
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().color = Color.white;
        tag = "Player";
        collision.collider.isTrigger = false;
    }
}


//referencia: https://medium.com/xp-inc/unity-movimentando-o-personagem-b6e1b091607f
