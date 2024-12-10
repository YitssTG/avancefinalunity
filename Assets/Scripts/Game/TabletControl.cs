using UnityEngine;
using UnityEngine.UI;

public class TabletControl : MonoBehaviour
{
    public GameObject panel;
    public bool playerEnter;
    public Button buttonClose;
    private void Awake()
    {
        buttonClose.onClick.AddListener(Close);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&playerEnter==true)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Close()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerEnter = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerEnter = false;
        }
    }
}
