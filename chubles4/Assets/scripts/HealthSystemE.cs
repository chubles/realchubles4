using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystemE : MonoBehaviour
{
    private const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public RectTransform health;
    public Image healthBars;
    
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead");
        }
        
        healthBars.fillAmount = maxHealth / 100f;
    }

}
