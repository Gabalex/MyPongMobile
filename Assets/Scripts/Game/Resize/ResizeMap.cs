using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeMap : MonoBehaviour {

    // Use this for initialization
    public int id;

	void Start () {
        switch (id)
        {
            case 0:
                ResizeTop();
                break;
            case 1:
                ResizeBottom();
                break;
            case 2:
                ResizeLeft();
                break;
            case 3:
                ResizeRight();
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResizeTop()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width, height / 50.0f, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2.0f, Screen.height, 0));
        this.transform.position = vo;
    }

    void ResizeBottom()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width, height / 50.0f, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2.0f, 0, 0));
        this.transform.position = vo;
    }

    void ResizeLeft()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 50.0f, height, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2.0f, 0));
        this.transform.position = vo;
    }

    void ResizeRight()
    {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 50.0f, height, 0);
        Vector2 vo = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2.0f, 0));
        this.transform.position = vo;
    }


}
