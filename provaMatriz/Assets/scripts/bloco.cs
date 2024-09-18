using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    private bool conquistado;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono;
   
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;

    }
    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        AtualizarCor(corDoJogador);
        if (jogador1)
        {
          jogadorDono = 1;
            GameManager.instance.ConquistarTerritorio();

        }
        else
        {
            jogadorDono= 2;
            GameManager.instance.ConquistarTerritorio();
        }
    }
    public void PegarConquistado() 
    {
        if (conquistado)
        {
            conquistado= true;
        }
        else
        {
            conquistado= false;
        }
    }
    public int PegarJogadorDono() 
    {
        if(conquistado)
        {
            return jogadorDono = 1;
        }
        else
        {
            return jogadorDono = 2;
        }
       
        
    }
    private void AtualizarCor(Color novaCor)
    {
        spriteRenderer.color = novaCor;
    }

   
}
