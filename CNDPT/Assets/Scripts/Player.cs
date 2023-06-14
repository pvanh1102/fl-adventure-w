//BTL CÔNG NGHỆ ĐA PHƯƠNG TIỆN BY PHẠM VIỆT ANH X NGUYỄN DUY VIỆT
//PHẠM VIỆT ANH : 2020605676
//NGUYỄN DUY VIỆT : 2020606223using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] private float moveForce = 50f;
    public int playerHealth;
    public int currentHealth;
    [SerializeField] private float jumpForce = 70f;
    [SerializeField] private float movementX;
    [SerializeField] private Rigidbody2D myBody;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Animator anim;
    private string WALK_ANIMATION = "Walk";
    private bool isGrounded;
    private string GROUND_TAG = "Ground";
    //private string ENEMY_TAG = "Enemy";
    private void Awake()
    {
        playerHealth = 100;
        currentHealth = playerHealth;
        myBody.AddForce(new Vector2(2, 2));//hệ thống di chuyển
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }    
            
        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
    }
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");// Điều khiển di chuyển
        transform.position += new Vector3(movementX, 0, 0) * Time.deltaTime * moveForce;
    }
    //Điều khiển hoạt ảnh
    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            sr.flipX = false;
            anim.SetBool(WALK_ANIMATION, true);
        }
        else if(movementX < 0)
        {
            sr.flipX= true;
            anim.SetBool(WALK_ANIMATION, true);
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }

    }
    //Điều khiển nhảy
    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);            
        }
    }
    //Điều khiển va chạm
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded= true;
        }
        if (collision.gameObject.name == "Bear" || collision.gameObject.name == "Bear(Clone)")
        {
            currentHealth -= 10;
        }
        else if (collision.gameObject.name == "Bat" || collision.gameObject.name == "Bat(Clone)")
        {
            currentHealth -= 15;
        }
        else if (collision.gameObject.name == "Rabbit" || collision.gameObject.name == "Rabbit(Clone)")
        {
            currentHealth -= 20;
        }
        else if (collision.gameObject.name == "Bug" || collision.gameObject.name == "Bug(Clone)")
        {
            currentHealth -= 30;
        }
        else if (collision.gameObject.name == "Slime" || collision.gameObject.name == "Slime(Clone)")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collector"))//......
        {
            gameObject.SetActive(false);
        }


    }
}
