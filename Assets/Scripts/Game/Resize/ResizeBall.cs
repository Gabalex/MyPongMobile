using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 50.0f, width / 50.0f);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
