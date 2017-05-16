using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     public void OnClick1Player()
    {
        PlayerPrefs.SetInt("mode", 0);
        ChangeScene();
    }

    public void OnClick2Player()
    {
        PlayerPrefs.SetInt("mode", 1);
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
