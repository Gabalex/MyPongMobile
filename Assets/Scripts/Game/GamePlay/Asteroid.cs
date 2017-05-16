using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    // Use this for initialization
    void Start() {
        float height = (float)(Camera.main.orthographicSize * 2.0f);
        float width = (float)(height * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(width / 20.0f, width / 20.0f);
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }
}
