using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.GetComponent<Text> ().text = Colors.theme;
	
		gameObject.GetComponent<Text> ().color = GameObject.Find("MainBackGround").GetComponent<Colors>().text;
	}
}
