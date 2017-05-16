using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePlayer : MonoBehaviour {

    // Use this for initialization
    public int id;

	void Start () {
        switch (id)
        {
            case 0:
                ResizePlayerOne();
                break;
            case 1:
                ResizePlayerTwo();
                break;
           
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResizePlayerOne()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 50.0f, height / 8, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width - (Screen.width / 20.0f), Screen.height / 2.0f, 0));
        this.transform.position = vo;
    }

    void ResizePlayerTwo()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 50.0f, height / 8, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 20.0f, Screen.height / 2.0f, 0));
        this.transform.position = vo;
    }
}
