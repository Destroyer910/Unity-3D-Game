using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShootLimited : MonoBehaviour
{
    [SerializeField] private GameObject bulletThing;
    public bool canShoot = false;
    public bool canStartShooting = true;

    
    void Update()
    {
        if(canShoot && canStartShooting)
        {
            canStartShooting = false;
            StartCoroutine(shoot());
        }
    }

    private IEnumerator shoot()
    {
        Debug.Log("ran");
        yield return new WaitForSeconds(3f);
        Instantiate(bulletThing, this.transform);
        if(canShoot)
        {
            StartCoroutine(shoot());
        }
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("enter");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlayerEnter");
            canShoot = true;
        }    
    }
    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canShoot = false;
            canStartShooting = true;
        }    
    }
}
