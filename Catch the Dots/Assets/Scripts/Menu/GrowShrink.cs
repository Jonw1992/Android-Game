using UnityEngine;
using System.Collections;

public class GrowShrink : MonoBehaviour {

	public float rate = .5f;
	public float size = 1;
	public float max = 1;
	public float min = 1;
	public float delay = 1;
	private bool growing;
	private float lasttime;

	// Use this for initialization
	void Start () {

		growing = true;

		//rate = Random.Range (.4f, .7f);
		//max = Random.Range (.1f, .5f);
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.localScale.x >= 1f * size * max) 
		{
			growing = false;
		} 
		if(transform.localScale.x < .9f * size * min)
		{
			growing = true;
		}

		if (growing) 
		{
			transform.localScale = new Vector3 (transform.localScale.x + Time.deltaTime * rate, transform.localScale.y + Time.deltaTime * rate, transform.localScale.z);
		} else 
		{
			transform.localScale = new Vector3 (transform.localScale.x - Time.deltaTime * rate, transform.localScale.y - Time.deltaTime * rate, transform.localScale.z);
		}

	
	}
}
