using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystemE : MonoBehaviour
{
    private const int MAX_HEALTH = 100;
    public int currentHealth = MAX_HEALTH;
    public RectTransform health;
    public Image healthBars;

    public Movment thePlayer;

    void Start()
    {
        thePlayer = FindObjectOfType<Movment>();
    }
    
    public void TakeDamage(int amount, Vector3 direction)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead");
            Destroy(gameObject);
        }
        Debug.Log((float)currentHealth / MAX_HEALTH);
        healthBars.fillAmount = (float)currentHealth / (float)MAX_HEALTH;
        
        thePlayer.KnockBack(direction);
    }

    public void TakeDamage(int amount)
    {
        throw new System.NotImplementedException();
    }
}
