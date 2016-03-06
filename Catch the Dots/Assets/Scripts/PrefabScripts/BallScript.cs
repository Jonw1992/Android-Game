using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallScript : MonoBehaviour
{

    // Use this for initialization

    public GameObject ball;
    private GameObject spawnPosition;
    public GameObject NewHighScore;
    public AudioClip hit;
    public AudioClip scored;
    public AudioClip levelUp;
    public AudioClip lostLife;
    public AudioClip gameOver;
    public int highScore = 0;
    string highScoreKey = "highscore";

    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0); 
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Catcher")
        {
            Destroy(gameObject);
            Score.score += 1;
            if (Score.score % 10 == 0)
            {
                AudioSource.PlayClipAtPoint(levelUp, transform.position);
            }
            else
            {
                AudioSource.PlayClipAtPoint(scored, transform.position);
            }


        }
        if (coll.gameObject.name == "Floor")
        {
            Score.lives -= 1;
            Destroy(gameObject);

            if (Score.lives == 2)
            {
                spawnPosition = GameObject.Find("Life1");
                ball.transform.position = spawnPosition.transform.position;
                Instantiate(ball);
                AudioSource.PlayClipAtPoint(lostLife, transform.position);
            }
            if (Score.lives == 1)
            {
                spawnPosition = GameObject.Find("Life2");
                ball.transform.position = spawnPosition.transform.position;
                Instantiate(ball);
                AudioSource.PlayClipAtPoint(lostLife, transform.position);
            }
            if (Score.lives == 0)
            {
                spawnPosition = GameObject.Find("Life3");
                ball.transform.position = spawnPosition.transform.position;
                Instantiate(ball);
                AudioSource.PlayClipAtPoint(gameOver, transform.position);

				EndGame.gameover = true;
				EndGame.message.enabled = true;

				Time.timeScale = 0;

                if(Score.setnewscore == true)
                {
                    Instantiate(NewHighScore);
                    NewHighScore.GetComponent<SpriteRenderer>().color = GameObject.Find("MainBackGround").GetComponent<Colors>().words;
                }

               

            }


        }
        if (coll.gameObject.name != "TopWall" && coll.gameObject.name != "Catcher")
        {
            AudioSource.PlayClipAtPoint(hit, transform.position);
        }



    }

}
