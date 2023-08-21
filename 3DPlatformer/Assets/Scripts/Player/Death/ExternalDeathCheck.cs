using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalDeathCheck : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject deathScreen;
    
    void Update()
    {
        if(!player.activeSelf)
        {
            StartCoroutine(deathStuff());
        }
    }

    private IEnumerator deathStuff()
    {
        yield return new WaitForSeconds(1f);
        deathScreen.SetActive(true);
    }
}
