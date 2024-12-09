using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactive : MonoBehaviour
{
    public bool jugadorCerca = false; 
    public abstract void Interactuar();
    public virtual void MostrarIndicador()
    {

    }
    public virtual void OcultarIndicador()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            jugadorCerca = true;
            MostrarIndicador();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            jugadorCerca = false;
            OcultarIndicador();
        }
    }
    private void Update()
    {
        if(!jugadorCerca && Input.GetKey(KeyCode.E))
        {
            Interactuar();
        }
    }
}

