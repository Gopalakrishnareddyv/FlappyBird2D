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

    private void Awake()
    {
        rbBird = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreUpdate = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbBird.velocity = Vector2.zero;
            rbBird.velocity = new Vector2(rbBird.velocity.x, speedBird);
        }
        BirdRotation();
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
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            scoreUpdate.ScoreIncrement();
        }
    }
}
