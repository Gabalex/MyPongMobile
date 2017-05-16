using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Use this for initialization
    public int maxScore;
    public int[] scorePlayer;

    public Text scoreUIPlayer1;
    public Text scoreUIPlayer2;

    public GameObject victoryUIGo;
    public GameObject origin;
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;

    public AsteroidSpawn astspawn;

    private Text _victoryUI;

    void Start()
    {
        scorePlayer = new int[2];
        scorePlayer[0] = 0;
        scorePlayer[1] = 0;

        if (PlayerPrefs.GetInt("mode") == 0)
        {
            player2.GetComponent<IAController>().enabled = true;
            player2.GetComponent<PlayerController>().enabled = false;
        }
        else
        {
            player2.GetComponent<IAController>().enabled = false;
            player2.GetComponent<PlayerController>().enabled = true;
        }
        _victoryUI = victoryUIGo.GetComponent<Text>();
        RestartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
        if (scorePlayer[0] == maxScore)
        {
            StopBall();
            victoryUIGo.SetActive(true);
            _victoryUI.text = "Victory\nPlayer 1";
            astspawn.StopSpawn();
        }
        else if (scorePlayer[1] == maxScore)
        {
            StopBall();
            victoryUIGo.SetActive(true);
            _victoryUI.text = "Victory\nPlayer 2";
            astspawn.StopSpawn();
        }
    }

    public void UpScore(int id)
    {
        scorePlayer[id]++;
        UpdateUIPlayer1();
        UpdateUIPlayer2();
    }

    void UpdateUIPlayer1()
    {
        scoreUIPlayer1.text = scorePlayer[0].ToString();
    }

    void UpdateUIPlayer2()
    {
        scoreUIPlayer2.text = scorePlayer[1].ToString();
    }

    public void RestartGame()
    {
        ball.transform.position = origin.transform.position;
        ball.GetComponent<Rigidbody>().velocity = Vector2.zero;
        StartCoroutine("RestartBall", 3.0f);
    }

    public void StopBall()
    {
        ball.transform.position = origin.transform.position;
        ball.GetComponent<Rigidbody>().velocity = Vector2.zero;
    }

    IEnumerator RestartBall(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ball.GetComponent<Ball>().StartBall();

    }

    public void ResetGame()
    {
        scoreUIPlayer1.text = "0";
        scoreUIPlayer2.text = "0";
        scorePlayer[0] = 0;
        scorePlayer[1] = 0;
        victoryUIGo.SetActive(false);
        astspawn.DestroyAllAsteroid();
        StartCoroutine("RestartBall", 3.0f);
        astspawn.StartSpawn();

    }

}
