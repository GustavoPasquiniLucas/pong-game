using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public int pontuacaoRed;
    public int pontuacaoGreen;
    public int pontuacaoBlue;
    public int pontuacaoYellow;


    public Text textoDePontuacao;
    public Text textoDePontuacaoRed;
    public Text textoDePontuacaoGreen;
    public Text textoDePontuacaoBlue;
    public Text textoDePontuacaoYellow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontuacaoDoJogador1 >= 20 || pontuacaoDoJogador2 >= 20)
        {
            if (pontuacaoDoJogador1 > pontuacaoDoJogador2 + 2)
            {
                textoDePontuacao.text = "Jogador 1 Venceu!";
            }

            if (pontuacaoDoJogador2 > pontuacaoDoJogador1 + 2)
            {
                textoDePontuacao.text = "Jogador 2 Venceu!";
            }
        }
    }

    public void AumentarPontuacaoDoJogador1(string cor)
    {
        pontuacaoDoJogador1 += 1;
        switch (cor)
        {
            case "red":
                pontuacaoRed += 1;
                break;
            case "green":
                pontuacaoGreen += 1;
                break;
            case "blue":
                pontuacaoBlue += 1;
                break;
            case "yellow":
                pontuacaoYellow += 1;
                break;

        }
        AtualizarTextoDePontuacao();

    }
    public void AumentarPontuacaoDoJogador2(string cor)
    {
        pontuacaoDoJogador2 += 1;
        switch (cor)
        {
            case "red":
                pontuacaoRed += 1;
                break;
            case "green":
                pontuacaoGreen += 1;
                break;
            case "blue":
                pontuacaoBlue += 1;
                break;
            case "yellow":
                pontuacaoYellow += 1;
                break;
        }
        AtualizarTextoDePontuacao();
    }

    public void AtualizarTextoDePontuacao()
    {
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        textoDePontuacaoRed.text = pontuacaoRed+"";
        textoDePontuacaoGreen.text = pontuacaoGreen+"";
        textoDePontuacaoBlue.text = pontuacaoBlue+"";
        textoDePontuacaoYellow.text = pontuacaoYellow+"";
    }

}
