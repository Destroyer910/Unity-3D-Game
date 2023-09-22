using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{

    public bool slowTime;
    public bool canSlowTime = true;
    public float slowTimeAmount = 5f;

    // Update is called once per frame
    void Update()
    {
        if(slowTime && canSlowTime)
        {
            Time.timeScale = 0.5f;
            canSlowTime = false;
        }
        if(!slowTime && !canSlowTime)
        {
            Time.timeScale = 1f;
            canSlowTime = true;
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        slowTime = true;   
        StartCoroutine(waitThenSpeed()); 
    }

    private IEnumerator waitThenSpeed()
    {
        yield return new WaitForSeconds(slowTimeAmount / 2);
        slowTime = false;
    }
}
