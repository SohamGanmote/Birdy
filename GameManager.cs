using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChareterSeletion()
    {
        SceneManager.LoadScene("Chareter");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenue");
    }

    public void AboutME()
    {
        SceneManager.LoadScene("AboutMe");
    }

    public void QuitGame()
    {
        print("Quit");
        Application.Quit();
    }
}
