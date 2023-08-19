using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCheckPoint : MonoBehaviour
{
    
    [SerializeField] private SpawningSO spawns;
    public GameObject particles;
    private bool canCheckpoint;
    
    void Start()
    {
      canCheckpoint = true;
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.name == "Third Person Player" && canCheckpoint)
      {
        canCheckpoint = false;
        spawns.spawnName = gameObject.name;
        Instantiate(particles, gameObject.transform); 
      }  
    }
    
}
