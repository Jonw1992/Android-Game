using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public GameObject ball;

	// Use this for initialization
	void Start () {
        StartCoroutine(pauseBall());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator pauseBall()
    {
        ball.GetComponent<Rigidbody2D>().gravityScale = 0;
        yield return new WaitForSeconds(.5F);
        ball.GetComponent<Rigidbody2D>().gravityScale = .3F;
    }
}
