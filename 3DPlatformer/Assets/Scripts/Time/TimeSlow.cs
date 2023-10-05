using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{

    public bool slowTime;
    public bool canSlowTime = true;
    public float DurationForWhichTimeIsSlowed = 5f;
    public float TimeScaleFactor = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if(slowTime && canSlowTime)
        {
            Time.timeScale = TimeScaleFactor;
            canSlowTime = false;
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);
        }
        if(!slowTime && !canSlowTime)
        {
            Time.timeScale = 1f;
            canSlowTime = true;
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + .5f, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Collided");
        slowTime = true;   
        StartCoroutine(waitThenSpeed()); 
    }

    private IEnumerator waitThenSpeed()
    {
        yield return new WaitForSecondsRealtime(DurationForWhichTimeIsSlowed);
        slowTime = false;
    }
}
