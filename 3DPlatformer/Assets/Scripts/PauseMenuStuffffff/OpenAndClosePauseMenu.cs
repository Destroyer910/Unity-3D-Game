using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClosePauseMenu : MonoBehaviour
{
    
    [SerializeField] private Timer timerScript;
    [SerializeField] private GameObject pauseMenu;
    private float trackTimeScale;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                timerScript.unpauseTheTimer();
                Time.timeScale = trackTimeScale;
            }
            else
            {
                pauseMenu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                timerScript.pauseTheTimer();
                trackTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }
        }
    }

    public void closePauseFromButton()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        timerScript.unpauseTheTimer();
        Time.timeScale = trackTimeScale;
    }
}
