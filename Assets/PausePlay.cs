using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePlay : MonoBehaviour
{
    Image img;
    public Sprite PlaySprite;
    public Sprite PauseSprite;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }
    public void Pause()
    {
        if (GameManager.IsPaused == false)
        {
            Time.timeScale = 0;
            GameManager.IsPaused = true;
            img.sprite = PlaySprite;
        }
        else if(GameManager.IsPaused==true)
        {
            Time.timeScale = 1;
            GameManager.IsPaused = false;
            img.sprite = PauseSprite;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
