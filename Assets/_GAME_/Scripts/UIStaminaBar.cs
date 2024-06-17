using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    [SerializeField] Slider staminaBar;
    [SerializeField] PlayerController playerStamina;
    void Start()
    {
        playerStamina = FindObjectOfType<PlayerController>();
    }


    void Update()
    {
        staminaBar.value = playerStamina.playerStamina;
    }
}
