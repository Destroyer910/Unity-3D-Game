using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStatsInOffice : MonoBehaviour
{

    [SerializeField] private StartTimeSO startTime;
    [SerializeField] private SpawningSO spawn;

    // Start is called before the first frame update
    void Start()
    {
        startTime.time = 0;
        spawn.spawnName = "StartSpawn";
    }
}
