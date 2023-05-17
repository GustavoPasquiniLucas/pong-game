using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{

    //criando variaveis
    public float velocidadeDoJogador;
    public bool jogador1;
    public bool raqueteV;

    public float yMinimo;
    public float yMaximo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentoDoJogador1();
        }

        if (jogador1 == false)
        {
            MovimentoDoJogador2();
        }
    }

    public void MovimentoDoJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        
        if (Input.GetKey(KeyCode.W) && raqueteV == true)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && raqueteV == true)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && raqueteV == false)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && raqueteV == false)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    public void MovimentoDoJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow) && raqueteV == true)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && raqueteV == true)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && raqueteV == false)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) && raqueteV == false)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
