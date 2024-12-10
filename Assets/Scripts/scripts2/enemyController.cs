using UnityEngine;

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


    public bool enContactoConPared;
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
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (direction == -1)
        {
           vision.transform.position = new Vector2(gameObject.transform.position.x - 5, vision.transform.position.y);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (_commponentRigidbody2d.position.x < minlimit)
        {
            direction = 1;
        }
        else if (_commponentRigidbody2d.position.x > maxlimit) 
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

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "player")
    //    {
    //        // Cuando el jugador entra en la visión, duplicar la velocidad
    //        speedx *= 2;
    //        playervision = true;
    //        Debug.Log("Jugador detectado por vision. Velocidad duplicada.");
    //    }
    //    if (collision.gameObject.tag == "ObjetoConRuido")
    //    {
    //        AlertaPorRuido();
    //    }
    //    if (collision.gameObject.tag == "pared")
    //    {
    //        Debug.Log("Entro");
    //        print(collision.gameObject.name);
    //        boxCollider2D.enabled = false;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {
            enContactoConPared = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {
            enContactoConPared = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            playervision = true;
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "pared")
    //    {
    //        boxCollider2D.enabled = true; 
    //    }
    //    if (collision.gameObject.tag == "player")
    //    {
    //        playervision = false;
    //        speedx /= 2;
    //    }
    //}

    public void AlertaPorRuido()
    {
        _commponentRigidbody2d.velocity = new Vector2(direction * velocidadAlerta, _commponentRigidbody2d.velocity.y);
    }
}
