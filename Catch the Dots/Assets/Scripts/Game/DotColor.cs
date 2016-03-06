using UnityEngine;
using System.Collections;

public class DotColor : MonoBehaviour {


	private Color[] colors;
	private int colorNum;
	// Use this for initialization
	void Start () 
	{

		Physics2D.IgnoreLayerCollision (LayerMask.NameToLayer("Button"), LayerMask.NameToLayer("Ball"));
	
		colors = new Color[5];



		colorNum = Random.Range (0, 5);



		colors [0] = Theme.color1;
		colors [1] = Theme.color2;
		colors [2] = Theme.color3;
		colors [3] = Theme.color4;
		colors [4] = Theme.color5;

		GetComponent<SpriteRenderer> ().color = colors [colorNum];
		GetComponent<TrailRenderer> ().material.color = colors [colorNum];



	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer> ().color = colors [colorNum];
		GetComponent<TrailRenderer> ().material.color = colors [colorNum];
	
	}

	void OnCollisionEnter2D(Collision2D c)
	{
		print ("collided");
		Destroy (gameObject);

	}
}
