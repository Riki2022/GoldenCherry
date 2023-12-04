using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melon : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.currentScore += 100;    
        collectSound.Play();
        Destroy(gameObject);
    }
}
