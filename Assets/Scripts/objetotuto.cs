using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetostutorial : MonoBehaviour
{
    public GameObject popupTip;
    public AudioSource sfx;
    public bool popupabierto;
    void Start()
    {
        popupTip.SetActive(false);
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sfx.Play();
        if (collision.gameObject.tag == "player" && !popupabierto)
        {
            Time.timeScale = 0;
            popupTip.SetActive(true);
            popupabierto = true;
        }
    }
    public void ClosePopUpTuto()
    {
        popupTip.SetActive(false);
        Time.timeScale = 1;
    }
}