using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    public string SceneToLoad;

    private GameObject go;
    private bool hasEntered = false;

    void Update() {
        if (hasEntered && Input.GetKeyDown(KeyCode.E)) {
            SceneManager.LoadScene(SceneToLoad);
        }
    }

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
