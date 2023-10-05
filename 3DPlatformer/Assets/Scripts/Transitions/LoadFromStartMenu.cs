using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFromStartMenu : MonoBehaviour
{

    [SerializeField] private GameObject transition;

    public void startGame()
    {
        transition.SetActive(true);
        StartCoroutine(startGameStuff());
    }

    private IEnumerator startGameStuff()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
