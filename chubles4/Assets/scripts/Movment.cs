using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    public CharacterController controller;
    private Vector3 moveDirection;
    public float gravityScale;

    public float knockBackForce;

    public float knockBackTime;

    private float knockBackCounter;
//hi    
    void Update()
    {
        if (knockBackCounter <= 0)
        {

            float yStore = moveDirection.y;

            moveDirection = (transform.forward * Input.GetAxis("Vertical")) +
                            (transform.right * Input.GetAxis("Horizontal"));
            moveDirection = moveDirection.normalized * movementSpeed;
            moveDirection.y = yStore;

            if (controller.isGrounded)
            {
                moveDirection.y = 0f;
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                }
            }

            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
            controller.Move(moveDirection * Time.deltaTime);
        }
        else
        {
            knockBackCounter -= Time.deltaTime;
        }

    }

    public void KnockBack(Vector3 direction)
    {
        knockBackCounter = knockBackTime;

        moveDirection = direction * knockBackForce;
        moveDirection.y = knockBackForce;
    }
}
