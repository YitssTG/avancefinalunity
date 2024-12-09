using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject popup;
    public GameObject popup2;
    public GameObject tablet1;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPopUp()
    {
        popup.SetActive(true);
        Time.timeScale = 0;
    } 
    public void ClosePopUp()
    {
        popup.SetActive(false);
        Time.timeScale = 1;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public void ShowPopUp2()
    {
        popup2.SetActive(true);
    }
    public void ClosePopUp2()
    {
        popup2.SetActive(false);
    }
    public void CloseTablet1()
    {
        tablet1.SetActive(false);
        Time.timeScale = 1;
    }
}
