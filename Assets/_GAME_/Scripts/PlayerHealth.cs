using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    
    private PlayerDeath playerDeath;

    private void Awake()
    {
        playerDeath = GetComponent<PlayerDeath>();
    }
      
    void Start()
    {
        currentHealth = maxHealth;
    }
    
   public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if(currentHealth <= 0)
        {
            playerDeath.Die();
        }    
    }

     public void RestoreHealth(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
