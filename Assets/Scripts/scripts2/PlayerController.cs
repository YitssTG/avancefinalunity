using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float vida;
    public float maximavida;
    public float SpeedX;
    public float Horizontal;
    private Rigidbody2D _componentRigidBody2D;
    private Animator _componentAnimator;
    private SpriteRenderer _componentSpriteRenderer;
    public bool canJump;
    public bool isJumping;
    public float jumpForce;
    public bool canDoor;
    public TeleportControl teleport;
    public VidaBarra vidaBarra;
    public bool changeScene;
    enemyController _enemyController;
    public GameObject popUpUse;
    public GameObject mano;
    //public GameObject poptablet1;
    //public bool EnTablet;
    //public GameObject isTablet;
    public Interactive currentinteractive;

    private void Start()
    {
        vida = maximavida;
        vidaBarra.StartVidaBarra(vida);
        popUpUse.SetActive(false);
        mano.SetActive(false);
        //poptablet1.SetActive(false);
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;
        vidaBarra.CambiarVidaActual(vida);
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        _componentRigidBody2D = GetComponent<Rigidbody2D>();
        _componentAnimator = GetComponent<Animator>();
        _componentSpriteRenderer = GetComponent<SpriteRenderer>();
       
        
    }
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Horizontal *= 1.5f;
        }
        _componentAnimator.SetInteger("isWalking", (int)Horizontal);
        if (Horizontal < 0)
        {
            _componentSpriteRenderer.flipX = false;
        }
        else if (Horizontal > 0)
        {
            _componentSpriteRenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))//&& canJump == true)
        {
            //jumpForce();
        }
        if (isJumping == true)
        {
            
        }
        if (Input.GetKeyDown(KeyCode.E) && canDoor == true)
        {
            
            teleport.Teleport();
        }
        if (Input.GetKeyDown(KeyCode.E) && changeScene == true)
        {
            
            SceneManager.LoadScene("Game 1");
        }
        //if (Input.GetKeyDown(KeyCode.E) && EnTablet == true)
        {
            //poptablet1.SetActive(true);
            //Time.timeScale = 0;
        }
        //if (EnTablet == false)
        {
           // poptablet1.SetActive(false);
        }

    }
    public void Interectuar()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentinteractive != null)
        {
            currentinteractive.Interactuar();
        }
    }
    private void Jump()
    {
        _componentRigidBody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        _componentAnimator.SetBool("isJumping", true);
    }
    public void TerminarInteraccion()
    {

    }

    private void FixedUpdate()
    {
        _componentRigidBody2D.velocity = new Vector2(Horizontal * SpeedX, _componentRigidBody2D.velocity.y);
        
        if (isJumping == true)
        {
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _componentAnimator.SetBool("isJumping", false);
        }
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.tag == "enemy" )
        {

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = false;
            isJumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interactive interactive = collision.GetComponent<Interactive>();
        if (interactive != null)
        {
            currentinteractive = interactive;
            popUpUse.SetActive(true);
            mano.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            canDoor = true;
            popUpUse.SetActive(true);
            mano.SetActive(true);
        }
        if (collision.gameObject.tag == "puertaescena")
        {
            popUpUse.SetActive(true);
            mano.SetActive(true);
            changeScene = true;
        }
        if (collision.gameObject.tag == "tablet")
        {
            //EnTablet = true;
            popUpUse.SetActive(true);
            mano.SetActive(true);
        }
        if (collision.gameObject.tag == "tablet")
        {
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Interactive interactive = collision.GetComponent<Interactive>();
        if(interactive != null)
        {
            currentinteractive = null;
            popUpUse.SetActive(false);
            mano.SetActive(false) ;
        }
         canDoor = false;   
         changeScene = false; 
    }
}
