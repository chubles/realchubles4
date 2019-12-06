using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaHeal : MonoBehaviour
{
    public int valueB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<HealthManager>().AddHealth(valueB);
            Destroy(gameObject);
        }
    }
}