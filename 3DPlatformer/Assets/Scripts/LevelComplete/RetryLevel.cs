using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    [SerializeField] private PreviousLevelSO previousLevel;

    public void retryLevel()
    {
        SceneManager.LoadScene(previousLevel.previousLevel);
        Time.timeScale = 1;
    }
}
