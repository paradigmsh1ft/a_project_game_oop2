using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int enemyHealth = 10;
     private int currentEnemyHealth;
    private Animator animator;
    private Rigidbody2D rb;
    private CircleCollider2D cCollider;



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
            StartCoroutine(Die());
        }
    }

      IEnumerator Die()
    {
        animator.SetBool("isMoving", false);
        animator.SetBool("isDefeated", true);
      
        rb.velocity = Vector2.zero;

        cCollider.enabled = false;

        yield return new WaitForSeconds(0.6f); 

        Destroy(gameObject); 
    }
}

