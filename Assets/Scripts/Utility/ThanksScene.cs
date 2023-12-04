using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksScene : MonoBehaviour
{
    public GameObject content;

    void Start()
    {
        StartCoroutine(Thanks());
    }

    IEnumerator Thanks()
    {
        yield return new WaitForSeconds(1f);
        content.SetActive(true);
    }
}
