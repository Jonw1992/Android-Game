using UnityEngine;
using System.Collections;

public class Blackout : MonoBehaviour {
	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Color.black;
		selector = GameObject.Find ("Selector");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseDown()
	{
		Theme.setBlackOut();
		selector.transform.position = transform.position;
	}
}
