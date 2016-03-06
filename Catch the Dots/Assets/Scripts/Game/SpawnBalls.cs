using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnBalls : MonoBehaviour {

	//Various game objects in the scene that need to be referred to later
    public GameObject ball;
    public GameObject playArea;
    public GameObject Background;
    public GameObject text;
    public GameObject highscore;
    public GameObject[] pegs;
    public GameObject[] dispensers;
    public GameObject[] graphics;
    public GameObject[] life;
	//-------------------------------------------------------------------


	//Private data used to control the game------------------------------
    private Color currentBall;
    private float speed;
    private GameObject spawnPosition;
    private int r;
	private float lastSpawnTime;
	//-------------------------------------------------------------------


	void Start () 
    {
        setUpColorScheme(); 
		spawnBall ();
	}
	
    void Update()
    {
		//if (Application.platform == RuntimePlatform.Android){} Why did I have this here?
        if (Input.GetKey(KeyCode.Escape)) //Check if user wants to go back to menu 
        {
            Time.timeScale = 1;
            Application.LoadLevel(0);
        }

		if(Time.time - lastSpawnTime > speed)//check if a ball should be spawned this frame
		{
			spawnBall();
		}
    }


	private void spawnBall()
	{
		//Randomly pick a dispenser to spawn a ball at----
		r = Random.Range(1, 9);

		if(r == 1)
		{
			spawnPosition = dispensers[0];
		}
		if(r == 2)
		{
			spawnPosition = dispensers[1];
		}
		if(r == 3)
		{
			spawnPosition = dispensers[2];
		}
		if(r == 4)
		{
			spawnPosition = dispensers[3];
		}
		if(r == 5)
		{
			spawnPosition = dispensers[4];
		}
		if(r == 6)
		{
			spawnPosition = dispensers[5];
		}
		if(r == 7)
		{
			spawnPosition = dispensers[6];
		}
		if(r == 8)
		{
			spawnPosition = dispensers[7];
		}
		if(r == 9)
		{
			spawnPosition = dispensers[8];
		}
		ball.transform.position = spawnPosition.transform.position;


		//--------------------------------------------------

		//Pick random color from Theme and set the ball color
		r = Random.Range(1, 6);
		if (r == 1)
		{
			ball.GetComponent<SpriteRenderer>().color = Theme.color1;
		}
		if (r == 2)
		{
			ball.GetComponent<SpriteRenderer>().color = Theme.color2;
		}
		if (r == 3)
		{
			ball.GetComponent<SpriteRenderer>().color = Theme.color3;
		}
		if (r == 4)
		{
			ball.GetComponent<SpriteRenderer>().color = Theme.color4;
		}
		else if(r==5)
		{
			ball.GetComponent<SpriteRenderer>().color = Theme.color5;
		}
		//--------------------------------------------------

		//Spawn the ball
		Instantiate(ball);


		//Check difficulty and set the last spawn time to current time 
		checkDifficulty();
		lastSpawnTime = Time.time;
	}


	// Checks the score and decides whether or not to make the balls spawn at a faster rate 
    void checkDifficulty()
    {
        if (Score.score >= 80 && Score.score%10 ==0)
        {
            speed = speed - .025F;
        }
        if (Score.score >= 70 && Score.score < 80)
        {
            speed = .5F;
        }
        if (Score.score >=50 && Score.score < 70)
        {
            speed = .75F;
        }
        if (Score.score >= 30 && Score.score < 50)
        {
            speed = 1F;
        }
        if (Score.score >= 10 && Score.score < 30)
        {
            speed = 1.25F;
        }
        if(Score.score < 10)
        {
            speed = 1.5F;
        }
    }
	//---------------------------------------------------------------------------------------



	void setUpColorScheme() //Color the objects to match the Theme data in the Theme class
	{
		playArea.GetComponent<SpriteRenderer>().color = Theme.gameArea;
		Background.GetComponent<SpriteRenderer>().color = Theme.background;
		GameObject.Find("LeftWall").GetComponent<SpriteRenderer>().color = Theme.walls;
		GameObject.Find("RightWall").GetComponent<SpriteRenderer>().color = Theme.walls;
		GameObject.Find("Catcher").GetComponent<SpriteRenderer>().color = Theme.catcher;
		text.GetComponent<Text>().color = Theme.text;
		highscore.GetComponent<Text>().color = Theme.text;
		//GameOverText.GetComponent<SpriteRenderer>().color = Theme.invertedtext;
		
		for (int i = 0; i < pegs.Length; i++)
		{
			pegs[i].GetComponent<SpriteRenderer>().color = Theme.pegs;
		}
		for (int i = 0; i < dispensers.Length; i++)
		{
			dispensers[i].GetComponent<SpriteRenderer>().color = Theme.dispensers;
		}
		for (int i = 0; i < life.Length; i++)
		{
			life[i].GetComponent<SpriteRenderer>().color = Theme.lives;
		}  
	}
	//---------------------------------------------------------------------------------------


}
