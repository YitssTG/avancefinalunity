using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class ojoscode : MonoBehaviour
{
    public AudioSource sfxojos;
    private SpriteRenderer spriteojos;
    public float velocidadAparicion = 0.005f;
    public float tiempovisible = 5f;
    public bool aparecio = false;
    public bool activado = false;
    public float tiempoactualvisible = 0f;

    void Awake()
    {
        spriteojos = GetComponent<SpriteRenderer>();
        spriteojos.color = new Color(1f, 0f, 0f, 0f);
    }
    void Update()
    {
        if (aparecio && spriteojos != null)
        {
            Color color = spriteojos.color;
            color.a = color.a + velocidadAparicion;
            spriteojos .color = color;
            if (color.a >= 1f)
            {
                color.a = 1f;
                tiempoactualvisible = tiempoactualvisible + Time.deltaTime;
                if ( tiempoactualvisible >= tiempovisible)
                {
                    color.a = color.a - velocidadAparicion;
                    color.a = 0f;
                    gameObject.SetActive(false);
                    aparecio = false;
                }
            }  
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && !activado)
        {
            activado = true;
            sfxojos.Play();   
            aparecio = true;
        }
    }
}

