using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameTransition : MonoBehaviour
{
    [SerializeField] private GameObject startTransition;
    void Start()
    {
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
