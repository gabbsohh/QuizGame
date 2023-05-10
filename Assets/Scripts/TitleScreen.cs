using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen: MonoBehaviour
{
    public GameManager gameManager;

    public void StartGame() 
    {
        gameManager.score = 0;
        SceneManager.LoadScene("Question1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
