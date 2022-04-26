using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public GameObject player;

    public void Pause(){
        if(player != null)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void Update() {
        if(player == null)
            Destroy(gameObject);
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
         SceneManager.LoadScene("MainMenue");
    }
}
