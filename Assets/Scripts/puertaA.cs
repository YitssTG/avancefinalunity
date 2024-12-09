using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaA : PuertaBase
{
    private void Start()
    {
        requiereLlave = false;
    }
    public override void Interactuar()
    {
        AbrirPuerta();
    }
    protected override void AbrirPuerta()
    {
        base.AbrirPuerta();
    }
}
