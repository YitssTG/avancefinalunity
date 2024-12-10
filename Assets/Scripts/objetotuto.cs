using UnityEngine;
using UnityEngine.UI;
public class Objetostutorial : Interactive
{
    public GameObject popupTip;
    public AudioSource sfx;
    public bool popupabierto;
    public Button mybutton;
    private bool active;
    private void Start()
    {
        mybutton.onClick.AddListener(Onclick);
    }
    private void Onclick()
    {
        Time.timeScale = 1;
        popupTip.SetActive(false);
        Destroy(this);
    }
    protected void Update()
    {
        if (interactivePlayer && active == false)
        {
            popupTip.SetActive(true);
            Time.timeScale = 0;
            sfx.Play();
            active = true;
        }
    }
}