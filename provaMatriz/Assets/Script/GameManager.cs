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

    private Bloco[,] bloco;
    private int territoriosConquistados;

    public static GameManager instance;

    #region Singleton
    private void Awake()
    {
       instance = this;
       bloco = new Bloco[linha,coluna];
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
                GameObject newBlock = Instantiate(block, position, Quaternion.identity);
                bloco[i,j] = newBlock;
            }
        }

        Vector2 posicaoJogador1 = new Vector2(coluna/2f, linha / 2f);
        Vector2 posicaoJogador2 = new Vector2(coluna  / 2f, linha / 2f);

        Camera.main.transform.position = new Vector3(linha*coluna / 2f - 0.5f, linha * coluna / 2f - 0.5f, -10);
        Camera.main.orthographicSize = linha*coluna / 2f;
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
                if ()
                {

                }
            }
        }
    }
}
