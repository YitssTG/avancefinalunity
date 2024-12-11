using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoControl : MonoBehaviour
{
    public GameObject Dialogo;
    void Start()
    {
        Dialogo.SetActive(true);
        Time.timeScale = 0;
    }
    void Update()
    {
        
    }
    public void CloseDialogo()
    {
        Dialogo.SetActive(false);
        Time.timeScale = 1;
    }
    public void CloseDialog2()
    {
        Dialogo.SetActive(false);
        Time.timeScale = 1;
    }
}
