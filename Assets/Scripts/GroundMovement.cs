using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float groundSpeed;
    BoxCollider2D boxcollider;
    float groundWidth;
    float pipeWidth;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Ground"))
        {
            boxcollider = GetComponent<BoxCollider2D>();
            groundWidth = boxcollider.size.x;
        }
        else if (gameObject.CompareTag("Pipe"))
        {
            pipeWidth = GameObject.FindGameObjectWithTag("Pipe").GetComponentInChildren<BoxCollider2D>().size.x;

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {
            transform.position = new Vector2(transform.position.x + groundSpeed * Time.deltaTime, transform.position.y);

        }
        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x <= -groundWidth)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
            }
        }
        else if (gameObject.CompareTag("Pipe"))
        {
            if (transform.position.x <= GameManager.bottomLeft.x - pipeWidth)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
