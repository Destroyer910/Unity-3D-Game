using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalDeathCheck : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Timer timerScript;
    
    void Update()
    {
        if(!player.activeSelf)
        {
            StartCoroutine(deathStuff());
            timerScript.STOPTHETIMER();
        }
    }

    private IEnumerator deathStuff()
    {
        yield return new WaitForSecondsRealtime(1f);
        deathScreen.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
