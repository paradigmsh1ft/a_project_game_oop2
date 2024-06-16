using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField]private Image HealthBar;
    [SerializeField]private float healthAmount = 100f;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        HealthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float heal)
    {
       healthAmount += heal;
       healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        HealthBar.fillAmount = healthAmount / 100f;
    }
}
