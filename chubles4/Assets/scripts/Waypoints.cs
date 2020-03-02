using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentPos = 0;
    float rotSpeed;
    float WPradius = 1;
    private float Speed = 5;


    void Start()
    {
        
    }

    private void Update()
    {

        if (Vector3.Distance(waypoints[currentPos].transform.position, transform.position) < WPradius)
        {
            currentPos++;
            if (currentPos >= waypoints.Length)
            {
                currentPos = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPos].transform.position,
            Time.deltaTime * Speed);
        
    }


}
