using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int enemyHealth = 10;


    private int currentEnemyHealth;

    private void Start()
    {
        currentEnemyHealth = enemyHealth;
    }

    public void TakeDamage(int damage)
    {
        currentEnemyHealth -= damage;
        EnemyDeath();
    }

    public void EnemyDeath()
    {
        if(currentEnemyHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}

