using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbBird;
    public float speedBird;
    int angle;
    int minAngle = -90;
    int maxAngle = 20;
    Score scoreUpdate;
    bool touchGround;
    public GameManager gameManager;
    Animator anim;
    public GameObject gameOverpanel;
    public GameObject scorepanel;
    public GameObject buttons;

    private void Awake()
    {
        rbBird = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreUpdate = GameObject.Find("ScoreManager").GetComponent<Score>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& GameManager.gameOver==false)
        {
            rbBird.velocity = Vector2.zero;
            rbBird.velocity = new Vector2(rbBird.velocity.x, speedBird);
        }
        BirdRotation();
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began && GameManager.gameOver==false)
            {

                rbBird.velocity = Vector2.zero;
                rbBird.velocity = new Vector2(rbBird.velocity.x, speedBird);
            }
        }
        BirdRotation();*/
    }

    private void BirdRotation()
    {
        if (rbBird.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle += 5;
            }
        }
        else if (rbBird.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle -= 5;
            }

        }
        if (touchGround == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            scoreUpdate.ScoreIncrement();
        }
        else if (collision.gameObject.CompareTag("Pipe"))
        {
            //Debug.Log("GameOver");
            gameManager.GameOver();
            gameOverpanel.SetActive(true);
            scorepanel.SetActive(false);
            buttons.SetActive(false);

            anim.enabled = false;
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            if (GameManager.gameOver == false)
            {
                //gameover
                gameManager.GameOver();
                gameOverpanel.SetActive(true);
                scorepanel.SetActive(false);
                buttons.SetActive(false);
                anim.enabled = false;
            }
            else
            {
                touchGround = true;
            }
        }
        
    }
    
}
