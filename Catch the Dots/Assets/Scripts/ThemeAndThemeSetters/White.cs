﻿using UnityEngine;
using System.Collections;

public class White : MonoBehaviour {

	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Theme.grey;
		selector = GameObject.Find ("Selector");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseDown()
	{
		Theme.setWhite();
		selector.transform.position = transform.position;
	}

}
