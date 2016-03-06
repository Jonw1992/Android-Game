using UnityEngine;
using System.Collections;

public class Purple : MonoBehaviour {

	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Theme.purple;
		selector = GameObject.Find ("Selector");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseDown()
	{
		Theme.setPurple ();
		selector.transform.position = transform.position;
	}
}
