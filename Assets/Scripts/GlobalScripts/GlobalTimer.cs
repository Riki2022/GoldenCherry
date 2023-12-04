using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool tickingTime = false;
    public static int seconds = 0, minutes = 0, hours = 0;
    public static int extendScore;
    void Start()
    {
        seconds = minutes = hours = 0;
    }
    // Update is called once per frame
    void Update()
    {
        extendScore = hours * 3600 + minutes * 60 + seconds;
        if (tickingTime == false)
        {
            StartCoroutine(AddSecond());
        }
    }
    IEnumerator AddSecond()
    {
        tickingTime = true;
        seconds++;
        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
        if (minutes >= 60)
        {
            minutes = 0;
            hours++;
        }
        timeDisplay.GetComponent<Text>().text = "" + hours + ":" + minutes +":" +seconds;
        yield return new WaitForSeconds(1); 
        tickingTime = false;
    }
}
