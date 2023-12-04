using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unsafe_Ground : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Death_Unsafe_Ground();
        }
    }
}
