using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto2Enemy : MonoBehaviour
{
    public AudioSource sfxenemymov;
    public GameObject enemigo;
    private bool SeEscucho = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "player" && enemigo != null && !SeEscucho)
        {
            sfxenemymov.Play();
            enemigo.GetComponent<movimientoEnemigo1>().enemyActive = true;
            SeEscucho=true;
        }
    }

}
