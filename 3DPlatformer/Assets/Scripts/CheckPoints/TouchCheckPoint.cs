using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCheckPoint : MonoBehaviour
{
    
    [SerializeField] private SpawningSO spawns;
    public GameObject particles;
    
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.name == "Third Person Player")
       {
            spawns.spawnName = gameObject.name;
            Instantiate(particles, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
       }  
    }
    
}
