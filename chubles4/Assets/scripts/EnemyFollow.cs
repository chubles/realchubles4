using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public int minRange;
    private Vector3 targetTran;
    private Transform target = null;
    private float enemySpeed = 10;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") target = other.transform;
    }
 
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") target = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back * enemySpeed : Vector3.forward * enemySpeed;
        transform.Translate(direction * Time.deltaTime); 
    }
}
