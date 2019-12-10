using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaHeal : MonoBehaviour
{
    public int valueB;
    [SerializeField] private HealthManager healthManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            healthManager.AddHealth(valueB);
            Destroy(gameObject);
        }
    }
}