using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinishButton : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject pauseMenu;

    public void PlayAgain()
    {
        buttonPress.Play();
        SceneManager.LoadScene(2);
    }

    public void NextLevel()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel++;
        SceneManager.LoadScene(2);
    }

    public void Resume()
    {
        buttonPress.Play();
        Time.timeScale = 1;
        PauseGame.gamePause = false;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
    }

    public void Restart()
    {
        buttonPress.Play();
        Time.timeScale = 1;
        PauseGame.gamePause = false;
        SceneManager.LoadScene(2);
    }

    public void QuitToMenu()
    {
        buttonPress.Play();
        Time.timeScale = 1;
        PauseGame.gamePause = false;
        SceneManager.LoadScene(1);
    }
}
