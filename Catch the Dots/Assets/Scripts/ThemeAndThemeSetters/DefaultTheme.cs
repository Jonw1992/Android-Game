using UnityEngine;
using System.Collections;

public class DefaultTheme : MonoBehaviour {


	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Theme.blue;
		selector = GameObject.Find ("Selector");
		selector.transform.position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnMouseDown()
	{
		Theme.setDefaultColors ();
		selector.transform.position = transform.position;
	}
}
