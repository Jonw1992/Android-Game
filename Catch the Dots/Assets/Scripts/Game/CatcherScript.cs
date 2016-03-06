using UnityEngine;
using System.Collections;

public class CatcherScript : MonoBehaviour 
    {
    public float velocity;
    public float leftboundary;
    public float rightboundary;
    private Vector3 position;

	// Use this for initialization
	void Start () 
    {
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        position.x += Input.GetAxis("Horizontal") * velocity;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if(position.x < leftboundary)
        {
            position.x = leftboundary;
        }
        if(position.x > rightboundary)
        {
            position.x = rightboundary;
        }

        transform.position = position;


	}

}
