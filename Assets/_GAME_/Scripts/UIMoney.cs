using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMoney : MonoBehaviour
{
    [SerializeField] MoneyManager moneyManager;
    [SerializeField] Text moneyText;
    void Start()
    {
        
    }

    void Update()
    {
        moneyText.text = moneyCount.ToString(); 
    }
}
