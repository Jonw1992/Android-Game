﻿using UnityEngine;
using System.Collections;

public class RedBlue : MonoBehaviour {

	private GameObject selector;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Theme.darkgrey;
		selector = GameObject.Find ("Selector");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnMouseDown()
	{
		Theme.setRedBlue();
		selector.transform.position = transform.position;
	}

}
