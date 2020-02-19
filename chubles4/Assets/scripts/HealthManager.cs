using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{ 
    public int currentHealth;
    public int maxHealth;
    public int death;
    public Text healthText;
    
   void Start()
   {
       currentHealth = maxHealth;
       Time.timeScale = 1;
       
   }
   
   public void HurtPlayer(int damage, Vector3 hitDirection)
   {
       currentHealth -= damage;
       healthText.text = "Health = " + currentHealth;
       if (currentHealth <= death)
       {
           print("oof");
           //Time.timeScale = 0;
           healthText.text = "Health = 0";
           SceneManager.LoadScene(0)/*SceneManager.GetActiveScene().buildIndex + 1)*/; 
           Cursor.lockState = CursorLockMode.None;
           
       }
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

   /*public void Death(int death)
   {
       if (currentHealth <= death)
       {
           Destroy(gameObject);
       }
   }*/
   
}

