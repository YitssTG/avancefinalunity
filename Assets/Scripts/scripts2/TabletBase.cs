using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TabletBase : MonoBehaviour
{
    public GameObject tablet;

    protected virtual void Start()
    {
        tablet.SetActive(false);
    }
    public virtual void CloseTablet()
    {
        tablet.SetActive(false);
        Time.timeScale = 1;
    }

    // Método para abrir la tablet cuando el jugador interactúa
    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            tablet.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

