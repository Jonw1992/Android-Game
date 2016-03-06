using UnityEngine;
using System.Collections;

public class trail : MonoBehaviour {

	public TrailRenderer t;
	// Use this for initialization
	void Start () {

		t = GetComponent<TrailRenderer> ();
		t.sortingLayerName = "Background";
		t.sortingOrder = 2;

		t.material.color= GetComponent<SpriteRenderer> ().color;
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
