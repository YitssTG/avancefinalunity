using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{
    public GameObject vision;
    public bool jugadorDetectado;
    Rigidbody2D _commponentRigidbody2d;
    SpriteRenderer _spriteRenderer;
    public float speedx;
    public bool canKill;
    public float minlimit;
    public float maxlimit;
    private int direction = 1;
    public float incrementSpeed = 2.5f;
    public bool playervision;
    public float campoVision;
    public float velocidadAlerta;
    void Awake()
    {
        _commponentRigidbody2d = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (direction == 1)
        {
            vision.transform.position = new Vector2(gameObject.transform.position.x + 5, vision.transform.position.y);
            _spriteRenderer.flipX = false;
        }
        if (direction == -1)
        {
            vision.transform.position = new Vector2(gameObject.transform.position.x - 5, vision.transform.position.y);
            _spriteRenderer.flipX = true;
        }
        if (_commponentRigidbody2d.position.x < minlimit)
        {
            direction = 1;
        }
        if (_commponentRigidbody2d.position.x > maxlimit) 
        {
            direction = -1; 
        }
    }
    private void FixedUpdate()
    {
        if (playervision)
        {
            _commponentRigidbody2d.velocity = new Vector2(direction * speedx * incrementSpeed, _commponentRigidbody2d.velocity.y);
        }
        else
        {
            _commponentRigidbody2d.velocity = new Vector2(direction * speedx, _commponentRigidbody2d.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            // Cuando el jugador entra en la visión, duplicar la velocidad
            speedx *= 2;
            playervision = true;
            Debug.Log("Jugador detectado por vision. Velocidad duplicada.");
        }
        if (collision.gameObject.tag == "ObjetoConRuido")
        {
            AlertaPorRuido();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            playervision = false;
            speedx /= 2;
            Debug.Log("Jugador salió de la visión. Velocidad restaurada.");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pared")
        {
            canKill = false;
        }
        else if (collision.gameObject.tag == "player")
        {
            print("jugador detectado");
            playervision = true;
        }
    }
    public void AlertaPorRuido()
    {
        _commponentRigidbody2d.velocity = new Vector2(direction * velocidadAlerta, _commponentRigidbody2d.velocity.y);
    }
}
