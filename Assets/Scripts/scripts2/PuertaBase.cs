using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuertaBase : Interactive
{
    public bool requiereLlave;
    public Transform teleportDestination;
    public string sceneToLoad;

   
    protected virtual void AbrirPuerta()
    {

    }
    public void CargarEscena()
    {
        if(sceneToLoad != "")
        {
            SceneManager.LoadScene("Game 1");
        }
    }
   
    //protected abstract void PerfomAction(PlayerController player);


}
