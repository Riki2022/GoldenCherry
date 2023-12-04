using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel;

    void Update()
    {
        if (redirectToLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(redirectToLevel);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
            
    }
}
