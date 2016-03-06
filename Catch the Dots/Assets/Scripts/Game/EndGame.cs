using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public static bool gameover;
	public static Canvas message;
	public Text text;
	// Use this for initialization
	void Start () {

		gameover = false;
		message = GameObject.Find("EndGameCanvas").GetComponent<Canvas>();
		message.enabled = false;
		PlayerPrefs.SetInt("numLosses", (PlayerPrefs.GetInt("numLosses") + 1));
		AdsGame.gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "Score: " + Score.score.ToString();
	}
}
