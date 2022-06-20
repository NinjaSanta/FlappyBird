using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text Score;
    public Text Highscore;
    
    public int score = 0;
    public int highscore;

    void Awake() {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        Score.text = score.ToString();
        Highscore.text = "Highscore: " + highscore.ToString();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (score>highscore) {
            highscore = score;
            Highscore.text = "Highscore: " + highscore.ToString();
        }
    }
    

    public void AddPoint() {
        score += 1;
        Score.text = score.ToString();
        if (score>highscore) {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    
}
