using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShadow : MonoBehaviour
{

    RaycastHit hit;
    [SerializeField] private GameObject shadow;

    // Update is called once per frame
    void Update()
    {   
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.green);
            shadow.transform.position = hit.point;
        }
    }
}
