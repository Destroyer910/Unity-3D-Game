using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{

    private bool timerGoing = true;
    private float currentTime;
    public TextMeshProUGUI timerItself;
    [SerializeField] private StartTimeSO time;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerGoing == true)
        {
            currentTime += Time.deltaTime;
        }
        TimeSpan timeItself = TimeSpan.FromSeconds(currentTime);
        timerItself.text = timeItself.ToString(@"mm\:ss\:fff");
    }

    public void STOPTHETIMER()
    {
        timerGoing = false;
        time.time = currentTime;
    }

    public void pauseTheTimer()
    {
        timerGoing = false;
    }

    public void unpauseTheTimer()
    {
        timerGoing = true;
    }

    public void touchedCheckPoint()
    {
        time.time = currentTime;
    }
}
