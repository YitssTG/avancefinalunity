using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojosaparece : MonoBehaviour
{
    private float time;
    bool detecterPlayer;
    private void Start()
    {
        time = 8;
    }
    private void Update()
    {
        if(detecterPlayer==true)
        {
            time-=Time.deltaTime;
            if(time <0)
            {
                Destroy(gameObject);
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this .gameObject.SetActive(true);
            detecterPlayer = true;
        }
    }
}
