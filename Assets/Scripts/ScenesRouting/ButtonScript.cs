using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Resume()
    {
        PauseGame.gamePause = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
    }
    public void Restart()
    {
        Resume();
        SceneManager.LoadScene(2);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }
    public void NextLevel()
    {
        RedirectToLevel.redirectToLevel++;
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        Resume();
        Cursor.lockState = CursorLockMode.None;
        RedirectToLevel.redirectToLevel = 1;
        SceneManager.LoadScene(2);
    }

    public void RollCredit()
    {
        SceneManager.LoadScene(3);
    }
}
