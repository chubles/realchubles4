using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{ 
    public int currentHealth;
    public int maxHealth;
  
    public Text healthText;
    
   void Start()
   {
       currentHealth = maxHealth;
   }
   
   public void HurtPlayer(int damage)
   {
       currentHealth -= damage;
       healthText.text = "Health = " + currentHealth;
   }
  
   public void AddHealth(int healthToAdd)
   {
       currentHealth += healthToAdd;
       if (currentHealth > maxHealth)
       {
           currentHealth = maxHealth;
       }
       healthText.text = "Health = " + currentHealth;
   }
   
}

