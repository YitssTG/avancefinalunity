using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puertaB : PuertaBase
{
    public GameObject tarjeta;

    private void Start()
    {
        requiereLlave = true;
    }
  
    protected override void AbrirPuerta()
    {
        base.AbrirPuerta();
        SceneManager.LoadScene("Game 1");
    }

}
