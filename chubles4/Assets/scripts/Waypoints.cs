using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentPos = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;

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
            Time.deltaTime * speed);
    }
}
