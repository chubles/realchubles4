using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakePickUp : MonoBehaviour
{
    public int value;
    [SerializeField] private GameManager gameManager;

   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           gameManager.AddCake(value);
           Destroy(gameObject);
       }
 
   }
}

