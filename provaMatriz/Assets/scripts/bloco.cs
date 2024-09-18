using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    private bool conquistado;
    private SpriteRenderer spriteRenderer;
    private int jogador;
   
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
