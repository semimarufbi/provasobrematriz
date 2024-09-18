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

    private void direção()
    {
        new Vector2();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (jogador1)
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                new Vector2(0, -3);
            }
        } 
    }
}
