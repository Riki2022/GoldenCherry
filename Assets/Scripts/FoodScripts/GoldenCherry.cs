using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldenCherry : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
        FindObjectOfType<GameManager>().Complete();
    }
}
