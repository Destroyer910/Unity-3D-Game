using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDoParticles : MonoBehaviour
{
    [SerializeField] private SpawningSO spawns;
    private ParticleSystem particles;

    void Start()
    {
        if(gameObject.name != spawns.spawnName)
        {
            particles = GetComponent<ParticleSystem>();
            particles.Stop(true);
        }
    }
}
