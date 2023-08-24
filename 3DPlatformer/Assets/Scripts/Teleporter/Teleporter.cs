using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    private GameObject go;
    private bool hasEntered = false;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player") && !hasEntered) {
            hasEntered = true;
            if (FloatingTextPrefab)
            {
                FloatingText(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasEntered = false;
            if (FloatingTextPrefab)
            {
                FloatingText(false);
            }
        }
    }

    void FloatingText(bool create)
    {
        if (create)
        {
            go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = "E";
            
        } else
        {
            GameObject.Destroy(go);
        }
    }
}
