using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto2Enemy : MonoBehaviour
{
    public AudioSource sfxenemymov;
    public movimientoEnemigo1 enemigo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            sfxenemymov.Play();
            enemigo.enemyActive = true;
        }
    }

}
