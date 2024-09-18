using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    const float velocidade = 0;

    [SerializeField]
    bool jogador1;
    [SerializeField]
    Color corDoJogador;
    private Vector2 direcao;

   
    // Update is called once per frame
    void Update()
    {
       if (jogador1)
        {
           
             if(Input.GetKeyDown(KeyCode.A))
            {
                new Vector2(0, -3);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                new Vector2(0, 3);
            }
            else
            {
                new Vector2(0, 0);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                new Vector2(-3, 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                new Vector2(3, 0);
            }
            else
            {
                new Vector2(0, 0);
            }
        } 

       else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                new Vector2(0, -3);
            } 
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                new Vector2(0, 3);
            }
            else
            {
                new Vector2(0, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                new Vector2(-3, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                new Vector2(3, 0);
            }
            else
            {
                new Vector2(0, 0);
            }
        }
        transform.Translate(direcao*velocidade*Time.deltaTime);
    }
}
