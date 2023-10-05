using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimeRotator : MonoBehaviour
{

    [SerializeField] private float rotateSpeedOriginal = 4f;
    private float rotateSpeed;
    public enum RotationAxis { X, Y, Z };
    public RotationAxis rotationAxis;
   

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        switch (rotationAxis)
        {
            case RotationAxis.X:
                transform.rotation = Quaternion.Euler(rotateSpeed, 0f, 0f);
                break;
            case RotationAxis.Y:
                transform.rotation = Quaternion.Euler(0f, rotateSpeed, 0f);
                break;
            case RotationAxis.Z:
                transform.rotation = Quaternion.Euler(0f, 0f, rotateSpeed);
                break;
        }
        
        rotateSpeed += rotateSpeedOriginal*Time.deltaTime*100;
    }
}
