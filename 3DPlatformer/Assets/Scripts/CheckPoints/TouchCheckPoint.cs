using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TouchCheckPoint : MonoBehaviour
{
    
    [SerializeField] private SpawningSO spawns;
    public GameObject particles;
    private bool canCheckpoint;
    private Timer timeScript;
    [SerializeField] private SpawningSO spawnStuff;
    
    void Start()
    {
      timeScript = GameObject.Find("TIME").GetComponent<Timer>();
      if(spawnStuff.spawnName == gameObject.name)
      {
        canCheckpoint = false;
      }
      else
      {
        canCheckpoint = true;
      }
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.name == "Third Person Player" && canCheckpoint)
      {
        canCheckpoint = false;
        spawns.spawnName = gameObject.name;
        GetComponent<AudioSource>().Play();
        Instantiate(particles, gameObject.transform);
        timeScript.touchedCheckPoint(); 
      }  
    }
    
}
