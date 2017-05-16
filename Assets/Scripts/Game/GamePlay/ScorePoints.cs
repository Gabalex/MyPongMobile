using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoints : MonoBehaviour {

    // Use this for initialization
    public int id;

    public GameManager gameManager;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("testTrigger");
        if (other.tag == "Ball")
        {
            gameManager.UpScore(id);
           // Destroy(other.gameObject);
            gameManager.RestartGame();
        }
    }
}
