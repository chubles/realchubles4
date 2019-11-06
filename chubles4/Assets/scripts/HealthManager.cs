using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }


    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
        
    }

    public void HealPlayer(int healamount)
    {
        currentHealth += healamount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    
    
}
