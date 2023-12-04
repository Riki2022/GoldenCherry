using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    public Transform groundCheck;
    public float groundDistant = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistant, groundMask);

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //Move Forward
        {
            if (z == 1)
            {
                animator.SetBool("isRunForward", true);
            }
            else
            {
                animator.SetBool("isRunForward", false);
            }
        }
        //Move Backward
        {
            if (z == -1)
            {
                animator.SetBool("isRunBackward", true);
            }
            else
            {
                animator.SetBool("isRunBackward", false);
            }
        }
        //Move Right
        {
            if (x == -1)
            {
                animator.SetBool("isRunRight", true);
            }
            else
            {
                animator.SetBool("isRunRight", false);
            }
        }
        //Move Left
        {
            if (x == 1)
            {
                animator.SetBool("isRunLeft", true);
            }
            else
            {
                animator.SetBool("isRunLeft", false);
            }
        }
        // Moving check
        {
            if( x != 0 || z != 0)
            {
                animator.SetBool("isMoving", true);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
        //Jumping
        {
            if (Input.GetButtonDown("Jump"))
            {
                animator.SetBool("isJump", true);
            }
            else
            {
                animator.SetBool("isJump", false);
            }
        }
        //Falling
        {
            if(isGrounded)
            {
                animator.SetBool("isFall", false);
            }
            else
            {
                animator.SetBool("isFall", true);
            }
        }
        //Sprinting
        {
            if (Input.GetAxis("Sprint") == 1)
            {
                animator.SetBool("isSprint", true);
            }
            else
            {
                animator.SetBool("isSprint", false);
            }
        }
    }
}
