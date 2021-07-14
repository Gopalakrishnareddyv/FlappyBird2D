using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public Text lastScore;
    public Text highScore;
    int lscore = 0;
    //int hscore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighestScore").ToString();
    }
    public void ScoreIncrement()
    {
        lscore++;
        text.text = "Score : " + lscore;
        lastScore.text = lscore.ToString();
        
        
        
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (lscore > PlayerPrefs.GetInt("HighestScore", 0))
        {
            //hscore = lscore;
            PlayerPrefs.SetInt("HighestScore", lscore);

        }
    }
}
