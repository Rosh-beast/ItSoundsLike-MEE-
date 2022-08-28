using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 2f;
    public float jumpSpeed = 5f;
    public float turnSmoothTime = 0.1f;
    public Transform cam;
    public Transform groundCheck;
    public LayerMask groundMask;

    public float gravity = -9.81f;
    public float groundDistance = 0.4f;

    Vector3 velocity;
    bool isGrounded;
    public float turnSmoothVelocity;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        MovePlayer();
    }

     public void MovePlayer()
    {
        float forward = Input.GetAxis("Horizontal");
        float sidewise = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(forward, 0, sidewise).normalized;

        if(playerMovement.magnitude >= 0.1)
        {
            float targetAngle = Mathf.Atan2(playerMovement.x, playerMovement.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f,angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpSpeed * -2f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
