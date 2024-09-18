using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;


    public int linha = 5; 
    public int coluna = 5; 
    public float spacing = 1.1f;

    //private Bloco[,] bloco;
    private int territoriosConquistados;

    static GameManager instance;

    #region Singleton
    private void Awake()
    {
        
    }
    #endregion
}
