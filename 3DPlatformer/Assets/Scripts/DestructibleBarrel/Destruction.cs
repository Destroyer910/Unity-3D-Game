using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject destroyedVersion;
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Explode();
        }
    }
    void Explode () {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
