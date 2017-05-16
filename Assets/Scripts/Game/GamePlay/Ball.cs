using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Use this for initialization
    int _dirx;
    int _diry;
    GameManager gm;

    public float startSpeed;
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartBall()
    {
        if (Random.Range(0, 2) == 0)
            _dirx = -1;
        else
            _dirx = 1;

        if (Random.Range(0, 2) == 0)
            _diry = -1;
        else
            _diry = 1;
        this.GetComponent<Rigidbody>().velocity = new Vector2(Random.Range(6, 8) * _dirx * startSpeed * Time.deltaTime, Random.Range(6, 8) * _diry * startSpeed * Time.deltaTime);
    }
}
