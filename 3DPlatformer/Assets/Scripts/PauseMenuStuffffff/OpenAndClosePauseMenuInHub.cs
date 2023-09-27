using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClosePauseMenuInHub : MonoBehaviour
{
    
    [SerializeField] private GameObject pauseMenu;

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
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
        }
    }

    public void closePauseFromButton()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
}
