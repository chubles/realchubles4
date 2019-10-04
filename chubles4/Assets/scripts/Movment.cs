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
    
    // Start is called before the first frame update
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    //87
    // Update is called once per frame
    void Update()
    {

       
        
       // moveDirection = new Vector3(Input.GetAxis("Horizontal") * movementSpeed , moveDirection.y, Input.GetAxis("Vertical") * movementSpeed);

       moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
       moveDirection = moveDirection.normalized * movementSpeed;
       
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
}
