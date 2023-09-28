using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FallingPlatform : MonoBehaviour
{
    [SerializeField]private float fallDelay = .5f;
    private float destroyDelay = 2f;
    private bool fall = false;
    private Vector3 targetPosition;

    private void Start() 
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y - 100, transform.position.z);    
    }
    private void Update() 
    {
        if(fall)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, 15f * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))   
        {
            StartCoroutine(Fall());
        }
    }
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        fall = true;
        Destroy(gameObject, destroyDelay);
    }
}
