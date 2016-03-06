using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
    public static int score;
    public static int lives;
    public Text text; 
    public Text HighScore;
    public int highScore = 0;
    string highScoreKey = "highscore";
    public static bool setnewscore;




	void Start () 
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        text = GetComponent<Text>();
        HighScore = GameObject.Find("HighScore").GetComponent<Text>();
        score = 0;
        lives = 3;
        setnewscore = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        text.text = ""+score;
        highScore = PlayerPrefs.GetInt(highScoreKey);
        if (Score.score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, Score.score);
            PlayerPrefs.Save();
            setnewscore = true;
        }
        HighScore.text = "High Score: "+highScore.ToString();
	}
}
