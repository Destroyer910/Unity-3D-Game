using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    [SerializeField] private SpawningSO spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Third Person Player");
        player.transform.position = GameObject.Find(spawnPoint.spawnName).transform.position;
        ThirdPersonMovement theScript = player.GetComponent<ThirdPersonMovement>();
        theScript.setNewPosition();
    }

    
}
