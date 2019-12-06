using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakePickUp : MonoBehaviour
{
    public int value;

   private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Player")
       {
           FindObjectOfType<GameManager>().AddCake(value);
           Destroy(gameObject);
       }
 
   }
}

