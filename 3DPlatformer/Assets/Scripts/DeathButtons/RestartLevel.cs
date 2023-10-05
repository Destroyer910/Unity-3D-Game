using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private GameObject endTransition;
    public void restartLevel()
    {
        StartCoroutine(loadStuff());
    }

    private IEnumerator loadStuff()
    {
        endTransition.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
