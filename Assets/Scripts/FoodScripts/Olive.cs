using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Olive : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.currentScore += 50;    
        collectSound.Play();
        Destroy(gameObject);
    }
}
