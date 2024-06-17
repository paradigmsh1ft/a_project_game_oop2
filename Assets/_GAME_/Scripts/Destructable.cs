using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    [SerializeField] private GameObject destroyItem;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<Weapon>()){
            Instantiate(destroyItem, transform.position, Quaternion.identity);
            Destroy(gameObject); 
        }
    }
}
