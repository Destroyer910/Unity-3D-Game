using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotator : MonoBehaviour
{

    // [SerializeField] private float rotateSpeedOriginal = 4f;
    public float rotateSpeed = 1f;
   

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, rotateSpeed, 0f);
        // rotateSpeed += rotateSpeedOriginal;
    }
}
