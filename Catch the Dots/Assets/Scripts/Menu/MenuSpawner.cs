using UnityEngine;
using System.Collections;

public class MenuSpawner : MonoBehaviour {


	public GameObject[] spawners;
	public GameObject ball;
	public float rate = 1;
	private float lasttime;
	// Use this for initialization
	void Start () 
	{
		lasttime = Time.time - 100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(rate < Time.time - lasttime)
		{
		int spawnpoint = Random.Range (0, spawners.Length);
		ball.transform.position = spawners [spawnpoint].transform.position;
		Instantiate (ball);
			lasttime = Time.time;
		}

	
	}
}
