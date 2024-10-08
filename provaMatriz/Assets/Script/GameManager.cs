using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject block;
    [SerializeField] GameObject jogador1;
    [SerializeField] GameObject jogador2;


    public int linha = 5; 
    public int coluna = 5; 
    public float spacing = 1.1f;

    private GameObject[,] bloco;
    private int territoriosConquistados;

    public static GameManager instance;

    #region Singleton
    private void Awake()
    {
       instance = this;
       bloco = new GameObject[linha,coluna];
       CriarGrade();
    }
    #endregion
    
    void CriarGrade()
    {
        for (int i = 0; i < linha; i++) 
        { 
            for(int j = 0; j < coluna; j++)
            {
                Vector2 position = new Vector2(i * spacing, j * spacing);
                GameObject novoBloco = Instantiate(block, position, Quaternion.identity);
                bloco[i,j] = novoBloco;
            }
        }

        Vector2 posicaoJogador1 = new Vector2(coluna/2f, linha / 2f);
        Vector2 posicaoJogador2 = new Vector2(coluna  / 2f, linha / 2f);

        Camera.main.transform.position = new Vector3(linha*coluna / 2f - 0.5f, linha * coluna / 2f - 0.5f, -10);
        Camera.main.orthographicSize = linha*coluna / 2f;

        Instantiate(block, posicaoJogador1,Quaternion.identity);
        Instantiate(block, posicaoJogador2, Quaternion.identity);

    }
    public void ConquistarTerritorio() 
    {
        territoriosConquistados ++;

        if (territoriosConquistados >= linha*coluna) 
        {
            int territorioJogador1;
            int territorioJogador2;

            for(int i = 0;i < bloco.Length; i++) 
            {
                if( PegarJogadorDono == 1 )
                {
                    territorioJogador1++;
                }
                else if(PegarJogadorDono == 2)
                {
                    territorioJogador2++;

                }
            }
        }
        FimDeJogo()
    }

    void FimDeJogo(int territoriosJogador1, int territoriosJogador2)
    {
        string nomeVencedor;

        if (territoriosJogador1 > territoriosJogador2) 
        {
            nomeVencedor = "Jogador 1 Venceu";
        }
        if (territoriosJogador1 < territoriosJogador2)
        {
            nomeVencedor = "Jogador 2 Venceu";
        }
        else
        {
            nomeVencedor = "Empate";
        }
        Debug.Log(nomeVencedor);
    }
}
