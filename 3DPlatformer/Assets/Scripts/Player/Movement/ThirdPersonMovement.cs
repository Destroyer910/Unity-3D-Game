using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Transform player;
    [SerializeField] private TrailRenderer trail;

    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask ground;

    bool isGrounded;
    bool isDashing;
    bool isRunning = false;
    bool canDash;

    public float speed = 6f;
    public float normalSpeed = 8f;
    public float runSpeed = 12f;
    public float dashSpeed = 100f;
    public float originalGravity = -9.81f;
    public float gravity = -9.81f;
    public float jumpPower = 15;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("testLog");
        if(other.gameObject.CompareTag("RunableWall"))
        {
            velocity.y = 0;
            Debug.Log("wow");
            gravity = -1f;
        }        
    }
    
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            gravity = originalGravity;
        }
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, ground);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
            canDash = false;
            trail.enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            isRunning = true;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = normalSpeed;
            isRunning = false;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            canDash = true;
            isGrounded = false;
            velocity.y = jumpPower;
        }

        if(Input.GetKeyDown(KeyCode.Q) && canDash)
        {
            canDash = false;
            isDashing = true;
            speed = dashSpeed;
            trail.enabled = true;
        }


        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            if(!isDashing)
            {
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }
            else
            {
                isDashing = false;
                controller.Move(moveDir.normalized * speed);
                if(isRunning)
                {
                    speed = runSpeed;
                }
                else
                {
                    speed = normalSpeed;
                } 
            }
        }
        else
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + player.eulerAngles.y;
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            if(isDashing)
            {
                isDashing = false;
                controller.Move(moveDir.normalized * speed);
                if(isRunning)
                {
                    speed = runSpeed;
                } 
                else
                {
                    speed = normalSpeed;
                }
            }
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    public void setNewPosition()
    {
        controller.enabled = false;
        controller.enabled = true;
    }
}
