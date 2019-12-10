using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    private float bulletSpeed = 1100;
    public GameObject bullet;

    }

    void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidbodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidbodyBullet.AddForce(tempRigidbodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 3f);
    }
    
    /*void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.collider.gameObject);
        GameObject hit = collision.gameObject;
        HealthSystemE health = hit.GetComponent<HealthSystemE>();

        if (health != null)
        {
            health.TakeDamage(10);
        }
        Destroy(gameObject);
    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
