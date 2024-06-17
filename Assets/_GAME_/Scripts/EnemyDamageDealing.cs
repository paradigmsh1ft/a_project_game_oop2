using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageDealing : MonoBehaviour
{
    [SerializeField] int damageAmount = 10;

       private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
