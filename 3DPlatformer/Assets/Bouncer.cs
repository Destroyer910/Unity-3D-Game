using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    // private bool colliding = false;
    // private Rigidbody rb;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // private void OnTriggerEnter(Collider other) {
    //     colliding = true;
    //     rb = other.GetComponent<Rigidbody>();
    //     rb.AddRelativeForce(transform.up*10f);
    //     Debug.Log(other);
    // }

    // private void OnTriggerExit(Collider other) {
    //     colliding = false;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (colliding) {
    //        rb.velocity = rb.velocity*1.5f; 
    //     }
        
    // }
    private void OnTriggerEnter(Collider other) {
        DeathHealthManager hp = other.GetComponent<DeathHealthManager>();
        hp.health = 0;
    }
}
