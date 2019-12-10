using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        HealthSystemE health = collision.gameObject.GetComponent<HealthSystemE>();

        if (health != null)
        {
            health.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
