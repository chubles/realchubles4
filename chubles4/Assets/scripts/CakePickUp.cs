﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakePickUp : MonoBehaviour
{

   public int value;
  
   // Start is called before the first frame update
   void Start()
   {
      
   }

   // Update is called once per frame
   void Update()
   {
      
   }

   private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Player")
       {
           FindObjectOfType<GameManager>().AddCake(value);
           Destroy(gameObject);
       }
 
   }
}

