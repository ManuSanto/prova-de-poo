using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public string tagDoPlayer;
    public int dano = 1;
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == tagDoPlayer)
        {
            int vida = colisao.gameObject.GetComponent<Personagem>().getVidas();
            colisao.gameObject.GetComponent<Personagem>().getVidas();
        }
    }

    void Start()
    {
        
    }
    
    }

    // Update is called once per frame
    