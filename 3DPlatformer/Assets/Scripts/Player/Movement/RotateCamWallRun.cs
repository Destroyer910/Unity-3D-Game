using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotateCamWallRun : MonoBehaviour
{

    public CinemachineVirtualCamera cam;
    private CinemachinePOV cPOV;

    void Start()
    {
        cPOV = cam.GetCinemachineComponent<CinemachinePOV>();
    }

    //Rotate the camera based on if the collider is the left or right one.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            if(gameObject.name == "Left")
            {
                Debug.Log("ROTATE");
                cPOV.m_HorizontalAxis.Value = -10f; 
            }
        }
    }
}
