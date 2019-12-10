using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;

    public bool useOffsetValues;

    public float rotateSpeed;

    public Transform pivot;

    public float maxVeiwAngle;
    public float minVeiwAngle;
    
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }
        
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;

    }
    
    void LateUpdate()
    {
        transform.LookAt(target);
        // get the x postion of the mouse and rotate the target
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        //get the position of the y and pivot
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical,0,0);

        //limit up down camera controll
        if (pivot.rotation.eulerAngles.x > maxVeiwAngle && pivot.rotation.eulerAngles.x <180f)
        {
            pivot.rotation = Quaternion.Euler(maxVeiwAngle,0,0);
        }

        if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 360f + minVeiwAngle)
        {
                        pivot.rotation = Quaternion.Euler(360f +minVeiwAngle,0,0);
        }
        
        // move the camera based on the current rotaion of the target and original offset
        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle,0);
        transform.position = target.position - (rotation * offset);

        //transform.position = target.position - offset;

        if (transform.position.y <target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y,transform.position.z);
        }
        transform.LookAt(target);
    }
}
