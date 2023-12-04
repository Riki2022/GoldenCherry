using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float boost = 1.7f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistant = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    Vector3 move;
    bool isGrounded,isFalling;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistant, groundMask);

        if (isGrounded && velocity.y < -17)
        {
            velocity.y = -1f;
            FindObjectOfType<GameManager>().Death_Fall();
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetAxis("Sprint") == 1)
        {
            move = transform.right * x * boost + transform.forward * z * boost;
        }
        else
        {
            move = transform.right * x  + transform.forward * z;
        }

        controller.Move(move*speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
