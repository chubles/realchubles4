using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive = 1;
    [SerializeField] private HealthManager healthManager;

   private void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag("Player"))
       {
           Vector3 hitDirection = other.transform.position = transform.position;
           hitDirection = hitDirection.normalized;
           
           healthManager.HurtPlayer(damageToGive, hitDirection);
       }
   }
}


