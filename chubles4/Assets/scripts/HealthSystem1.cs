using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem1 : MonoBehaviour
{
<<<<<<< Updated upstream:chubles4/Assets/scripts/HealthSystem.cs
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public RectTransform health;
    private Image healthBars = GameObject.Find("healthbar").GetComponent<Image>();


    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead");
        }


        healthBars.fillAmount = maxHealth / 100f;
=======
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> Stashed changes:chubles4/Assets/scripts/HealthSystem1.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
