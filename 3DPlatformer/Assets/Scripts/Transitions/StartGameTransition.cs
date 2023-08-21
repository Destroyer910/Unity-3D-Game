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
    }

    private IEnumerator disableQuick()
    {
        yield return new WaitForSeconds(3f);
        startTransition.SetActive(false);
    }

    
}
