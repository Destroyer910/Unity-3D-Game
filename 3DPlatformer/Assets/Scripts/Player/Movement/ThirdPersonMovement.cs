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
    bool canMove = true;

    public float speed = 6f;
    public float normalSpeed = 8f;
    public float runSpeed = 12f;
    public float dashSpeed = 100f;
    public float originalGravity = -9.81f;
    public float gravity = -9.81f;
    public float jumpPower = 15;
    private Vector3 tempVelo;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    //Start wallrunning 
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            velocity.y = 0;
            gravity = -1f;
        }        
    }
    
    //Stop wallrunning 
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("RunableWall"))
        {
            gravity = originalGravity;
        }
    }

    
    //Get the angle of target object.
    float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up) 
	{
		Vector3 perp = Vector3.Cross(fwd, targetDir);
		float dir = Vector3.Dot(perp, up);
		
		if (dir > 0f) 
		{
			return 1f;
		} 
		else if (dir < 0f) 
		{
			return -1f;
		}
		else 
		{
			return 0f;
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

        //Start running when shift is pressed.
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            isRunning = true;
        }
        //Stop running when shift is let go.
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = normalSpeed;
            isRunning = false;
        }

        //Jump
        if(Input.GetButtonDown("Jump") && isGrounded && canMove)
        {
            canDash = true;
            isGrounded = false;
            velocity.y = jumpPower;
        }

        //Do the dash.
        if(Input.GetKeyDown(KeyCode.Q) && canDash && canMove)
        {
            canDash = false;
            isDashing = true;
            trail.enabled = true;
            dash();
        }


        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f && canMove) //If the the player has any of the non jump movement buttons pressed then do the movment math.
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            if(!isDashing)
            {
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }
            
        }
        
        if(canMove)
        {
            //Gravity.
            velocity.y += gravity * Time.deltaTime;

            //Do the vertical movement.
            controller.Move(velocity * Time.deltaTime);
        }
    }

    //Disable and enable the controller to allow for the position of the controller to be updated because character controller is weird :(
    public void setNewPosition()
    {
        controller.enabled = false;
        controller.enabled = true;
    }

    public void dash()
    {
        //Calculate the move direction
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

        isDashing = false;

        //Do the actual dash.
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
