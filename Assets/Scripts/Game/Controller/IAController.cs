using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAController : MonoBehaviour {

    // Use this for initialization
    public int move = 0;
    public GameObject ball;

    public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (move == 1)
        {
            Vector2 vo = new Vector2(this.transform.position.x, ball.transform.position.y);
            this.transform.position = Vector2.MoveTowards(this.transform.position, vo, speed * Time.deltaTime);
        }
	}
}
