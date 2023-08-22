using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotator : MonoBehaviour
{

    [SerializeField] private float rotateSpeedOriginal = 4f;
    private float rotateSpeed = 4f;
    private float turnSmoothTime = 2f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, rotateSpeed, 0f);
        rotateSpeed += rotateSpeedOriginal;
    }
}
