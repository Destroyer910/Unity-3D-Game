using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalDeathCheck : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Timer timerScript;
    [SerializeField] private TotalDeaths totalDeaths;
    [SerializeField] private DeathsThisLevel deathsThisLevel;
    private bool canDeathStuff = true;
    
    void Update()
    {
        if(!player.activeSelf && canDeathStuff)
        {
            StartCoroutine(deathStuff());
            timerScript.STOPTHETIMER();
        }
    }

    private IEnumerator deathStuff()
    {
        canDeathStuff = false;
        yield return new WaitForSecondsRealtime(1f);
        deathScreen.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        totalDeaths.totalDeaths += 1;
        deathsThisLevel.deathsThisLevel += 1;
    }
}
