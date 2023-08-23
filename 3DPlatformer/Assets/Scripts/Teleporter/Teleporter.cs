using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("Teleporter Activated!");
        }
    }
}
