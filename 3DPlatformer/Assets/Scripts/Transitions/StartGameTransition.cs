using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameTransition : MonoBehaviour
{
    public AudioSource BackgroundMusic;
    public MusicState MusicManager;
    [SerializeField] private GameObject startTransition;
    void Start()
    {
        BackgroundMusic.time = MusicManager.time;
        startTransition.SetActive(true);
        StartCoroutine(disableQuick());
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private IEnumerator disableQuick()
    {
        yield return new WaitForSecondsRealtime(3f);
        startTransition.SetActive(false);
    }

    
}
