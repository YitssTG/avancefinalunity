using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
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
    public bool changeScene;
    enemyController _enemyController;
    public GameObject popUpUse;
    public GameObject mano;
    //public GameObject poptablet1;
    //public bool EnTablet;
    //public GameObject isTablet;

    private void Start()
    {
        popUpUse.SetActive(false);
        mano.SetActive(false);
        //poptablet1.SetActive(false);
        isJumping = true;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _componentAnimator.SetBool("IsCrounch", true);
        }

    }
    private void Jump()
    {
        if(isJumping == true)
        {
            _componentRigidBody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            _componentAnimator.SetBool("isJumping", true);
        }
    }
    private void FixedUpdate()
    {
        _componentRigidBody2D.velocity = new Vector2(Horizontal * SpeedX, _componentRigidBody2D.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _componentAnimator.SetBool("isJumping", false);
            canJump = true;
            isJumping = true;
        }
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
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
        if (collision.gameObject.tag == "tablet")
        {
            popUpUse.SetActive(true);
            mano.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tablet")
        {
            popUpUse.SetActive(false);
            mano.SetActive(false);
        }
    }
}
