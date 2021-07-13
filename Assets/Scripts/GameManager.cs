using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool gameOver;
    public static bool gameHasStarted;
    public static bool IsPaused;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        IsPaused = false;
    }
    public void GameOver()
    {
        gameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickOk()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
