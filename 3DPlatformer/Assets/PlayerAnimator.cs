using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool Walking = (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"));
        if(Walking) {
            animator.SetBool("isWalking", true);
        }
        if(!Walking) {
            animator.SetBool("isWalking", false);
        }
    }
}
