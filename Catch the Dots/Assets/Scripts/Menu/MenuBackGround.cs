using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuBackGround : MonoBehaviour {

	public GameObject titleGraphic;
	// Use this for initialization
	void Start () {

		Theme.setDefaultColors ();
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer> ().color = Theme.background;
		titleGraphic.GetComponent<Image>().color = Theme.catcher;
	}
}
