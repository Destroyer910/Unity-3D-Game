using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamWallRun : MonoBehaviour
{
    //Rotate the camera based on if the collider is the left or right one.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RunnableWall"))
        {
            if(gameObject.name == "Left")
            {
                
            }
        }
    }
}
