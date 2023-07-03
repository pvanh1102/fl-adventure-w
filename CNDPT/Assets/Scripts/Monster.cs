using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    public Rigidbody2D myBody;
    public LogicScripts logic;
    [SerializeField] private Animator anim;
    private string WALK_ANIMATION = "Walk";
    private float ishowspeed;
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    // Start is called before the first frame update
    void Awake()
    {
        if (name == "Bear"||name == "Bear(Clone)")
            maxHealth= 150;
        if (name == "Bat" || name == "Bat(Clone)")
            maxHealth = 75;
        if (name == "Rabbit" || name == "Rabbit(Clone)")
            maxHealth = 100;
        if (name == "Bug" || name == "Bug(Clone)")
            maxHealth = 80;
        myBody = GetComponent<Rigidbody2D>();//Gắn thuộc tính vật lý cho các đối tượng 
        currentHealth = maxHealth;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed,myBody.velocity.y);// điều khiển chức năng dy chuyển của quát vật
        ishowspeed = speed;
        AnimateMonster();
    }
    //Điểu khiển hoạt ảnh của quái vật
    void AnimateMonster()
    {
        if (ishowspeed > 0)
        {
            
            anim.SetBool(WALK_ANIMATION, true);
        }
        else if (ishowspeed < 0)
        {
            
            anim.SetBool(WALK_ANIMATION, true);
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            logic.addScore(1);
            Die();
        }
        
    }   
    void Die()
    {
        Debug.Log("Ua.");
        this.gameObject.SetActive(false);
    }
}
