using UnityEngine;
using System.Collections;

public class MoveBlocks3 : MonoBehaviour
{

    public float left;
    public float right;
    private int r;
    // Use this for initialization
    void Start()
    {

        left = transform.position.x - .75F;
        right = transform.position.x + .75F;



    }

    // Update is called once per frame
    void Update()
    {

        if (Score.score >= 50)
        {
            GameObject.Find("Row1").transform.position = new Vector3(Mathf.PingPong(Time.time, right - left) + left, transform.position.y, transform.position.z);
        }
    }


}
