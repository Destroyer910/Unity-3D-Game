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
        if (Input.GetKey(KeyCode.LeftShift)) {
            animator.SetBool("isSprinting", true);
        } else {
            animator.SetBool("isSprinting", false);
        }
        if(ThirdPersonMovement.isGrounded == false) {
            animator.SetBool("isJumping", true);
        } else () {
            animator.SetBool("isJumping", false);
        }
        if (ThirdPersonMovement.isWallRunning == true) {
            animator.SetBool("isWallrunning", true);
        } else {
            animator.SetBool("isWallrunning", false);
        }
    }
}
