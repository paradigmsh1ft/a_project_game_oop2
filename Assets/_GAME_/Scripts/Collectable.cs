using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] MoneyManager moneyManager;
    [SerializeField] CollectableManager collectableManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Money"))
        {
            moneyManager.moneyCount++;
            Destroy(other.gameObject);
        }
        
        else if(other.gameObject.CompareTag("Collectable"))
        {
            collectableManager.count++;
            Destroy(other.gameObject);     
        }
    }
    
}
