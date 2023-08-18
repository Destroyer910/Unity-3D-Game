using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteParticles : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitThenDestroy());
    }

    public IEnumerator waitThenDestroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
