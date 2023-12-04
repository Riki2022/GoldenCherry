using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banana : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.currentScore += 200;    
        collectSound.Play();
        Destroy(gameObject);
    }
}
