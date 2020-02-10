using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoints : MonoBehaviour
{
    /*public GameObject[] waypoints;
    int currentPos = 0;
    float rotSpeed;
    float WPradius = 1;

    private NavMeshAgent Mob;
    public GameObject Player;
    public float MobDistanceRun = 4;*/
    

    public int maxRange;
    public int minRange;
    private Vector3 targetTran;
    private Transform target = null;
    private float enemySpeed = 5;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") target = other.transform;
    }
 
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") target = null;
    }

    void Start()
    {
        /*target = GameObject.FindWithTag("Player");
        targetTran = target.transform.position;*/
    }

    private void Update()
    {
        /*if ((Vector3.Distance(transform.position, target.transform.position) < maxRange) &&
            (Vector3.Distance(transform.position, target.transform.position) > minRange))
        {
            transform.LookAt(targetTran);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }*/
        
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back * enemySpeed : Vector3.forward * enemySpeed;
        transform.Translate(direction * Time.deltaTime);
        
        
        /*if (Vector3.Distance(waypoints[currentPos].transform.position, transform.position) < WPradius)
        {
            currentPos++;
            if (currentPos >= waypoints.Length)
            {
                currentPos = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPos].transform.position,
            Time.deltaTime * Speed);*/
    }

    /*private void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);
        }
    }

    private void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }*/


}
