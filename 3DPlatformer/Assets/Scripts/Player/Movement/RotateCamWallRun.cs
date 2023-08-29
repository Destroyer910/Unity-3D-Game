using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotateCamWallRun : MonoBehaviour
{

    [SerializeField] private GameObject camMain;
    [SerializeField] private GameObject camForLeft;
    [SerializeField] private GameObject camForRight;

    [SerializeField] private CinemachineVirtualCamera virtualCamera1;

    //Rotate the camera based on if the collider is the left or right one.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            
            if(gameObject.name == "Left")
            {
                camMain.SetActive(false);
                camForLeft.SetActive(true);
                
            }
            else if(gameObject.name == "Right")
            {
                camMain.SetActive(false);
                camForRight.SetActive(true);
            }
        }
    }

    //Switch to the main camera when it's done colliding.
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            camForLeft.SetActive(false);
            camForRight.SetActive(false);
            camMain.SetActive(true);
        }
    }

    
}
