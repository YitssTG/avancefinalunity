using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaA : PuertaBase
{
    private void Start()
    {
        requiereLlave = false;
    }
    
    protected override void AbrirPuerta()
    {
        base.AbrirPuerta();
    }
}
