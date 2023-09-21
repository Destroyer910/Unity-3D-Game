using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{

    public bool slowTime;

    // Update is called once per frame
    void Update()
    {
        if(slowTime)
        {
            Time.timeScale = 0.5f;
        }
    }
}
