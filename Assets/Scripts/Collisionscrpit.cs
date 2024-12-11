using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionscrpit : MonoBehaviour
{
    public GameObject dialogo2;
    // Start is called before the first frame update
    void Start()
    {
       dialogo2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialogo2.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerExitr2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
        //    dialogo2.SetActive(false);
        //    Time.timeScale = 1;
        //}
    }
    public void CloseDialogo2()
    {
        dialogo2.SetActive(false);
        Time.timeScale = 1;
    }

}
