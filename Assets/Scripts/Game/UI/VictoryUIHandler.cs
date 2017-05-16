using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VictoryUIHandler : MonoBehaviour
{

    public GameManager gm;

    public void OnClickReset()
    {
        gm.ResetGame();
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
