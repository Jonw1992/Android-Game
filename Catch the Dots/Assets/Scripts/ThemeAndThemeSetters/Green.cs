using UnityEngine;
using System.Collections;

public class Green : MonoBehaviour {

	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Theme.green;
		selector = GameObject.Find ("Selector");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseDown()
	{
		Theme.setGreen ();
		selector.transform.position = transform.position;
	}
}
