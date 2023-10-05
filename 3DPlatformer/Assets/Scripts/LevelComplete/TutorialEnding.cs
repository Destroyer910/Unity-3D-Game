using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialEnding : MonoBehaviour
{

    [SerializeField] private GameObject endTransition;
    [SerializeField] private SpawningSO spawnStuff;
    [SerializeField] private StartTimeSO time;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Third Person Player")
        {
            StartCoroutine(endLevelStuff());
        }
    }

    //The ACTUAL end level stuff :O
    private IEnumerator endLevelStuff()
    {
        endTransition.SetActive(true);
        yield return new WaitForSeconds(2f);
        time.time = 0;
        spawnStuff.spawnName = "StartSpawn";
        SceneManager.LoadScene("StartMenu");
    }
}
