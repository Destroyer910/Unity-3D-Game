using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActualEnding : MonoBehaviour
{
    private Timer timeScript;
    [SerializeField] private GameObject endTransition;
    [SerializeField] private PreviousLevelSO previousLevel;

    void Start()
    {
        timeScript = GameObject.Find("TIME").GetComponent<Timer>();
    }

    //When the player interacts with the end level object run the stuff :P
    void OnTriggerEnter(Collider other)
    {
        timeScript.STOPTHETIMER();
    }

    //The ACTUAL end level stuff :O
    private IEnumerator endLevelStuff()
    {
        endTransition.SetActive(true);
        yield return new WaitForSeconds(2f);
        previousLevel.previousLevel = SceneManager.GetActiveScene().ToString();
        SceneManager.LoadScene("LevelEnd");
    }
}
