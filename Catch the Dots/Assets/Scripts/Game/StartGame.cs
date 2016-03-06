using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	private bool touched;

	// Use this for initialization
	void Start () 
	{
		//PlayerPrefs.DeleteAll ();
		touched = false;
		AdsGame.gameOver = false;
		AdsGame.numLoses = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (!touched) 
		{
			GetComponent<SpriteRenderer> ().color = Theme.text;
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	void OnMouseDown()
	{
		GetComponent<SpriteRenderer> ().color = Theme.catcher;
		touched = true;
	}

	void OnMouseUp()
	{
		if (touched) 
		{
			Application.LoadLevel (1);
		}
	}

}
