using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform player;
    //public GameObject mouse;
    public Transform spawnPoint;
    public AudioSource hitGround;
    public GameObject deathBox;
    public GameObject deathMessage;

    public AudioSource LevelComplete;
    public GameObject backGroundMusic;
    public GameObject globalTime;

    public GameObject time;
    public GameObject score;
    public GameObject line;
    public GameObject totalScore;

    public GameObject playAgain;
    public GameObject nextLevel;

    public int timeCalc;

    public void Death_Fall()
    {
        hitGround.Play();
        StartCoroutine(DeathSequene());
    }

    public void Death_Ocean()
    {
        StartCoroutine(DeathSequene());
    }

    public void Death_Unsafe_Ground()
    {
        hitGround.Play();
        deathMessage.GetComponent<Text>().text = "You got poisoned by sludge";
        StartCoroutine(DeathSequene());
    }

    public void Death_Acid()
    {
        deathMessage.GetComponent<Text>().text = "You melted by acid";
        StartCoroutine(DeathSequene());
    }

    public void Complete()
    {
        StartCoroutine(IComplete());
    }

    public IEnumerator DeathSequene()
    {
        deathBox.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(3);

        deathBox.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<Animator>().enabled = true;

        player.transform.position = spawnPoint.transform.position;
        player.transform.rotation = Quaternion.identity;

        Physics.SyncTransforms();
    }

    public IEnumerator IComplete()
    {
        timeCalc = GlobalScore.currentScore + GlobalTimer.extendScore * -10;
        time.GetComponent<Text>().text = "" + "Time: " + GlobalTimer.hours + ":" + GlobalTimer.minutes + ":" + GlobalTimer.seconds;
        score.GetComponent<Text>().text = "" + "Score: " + GlobalScore.currentScore;
        totalScore.GetComponent<Text>().text = "" + "Total Score: " + timeCalc;

        globalTime.SetActive(false);
        backGroundMusic.SetActive(false);
        LevelComplete.Play();

        player.GetComponent<PlayerMovement>().enabled = false;
        //mouse.GetComponent<MouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        player.GetComponent<Animator>().enabled = false;


        time.SetActive(true);
        yield return new WaitForSeconds(1);
        score.SetActive(true);
        yield return new WaitForSeconds(1);
        line.SetActive(true);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1);
        playAgain.SetActive(true);
        nextLevel.SetActive(true);

    }
}
