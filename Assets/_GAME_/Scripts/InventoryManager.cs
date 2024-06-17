using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] UIInventory inventoryUI;

    public int inventorySize = 15;

    void Awake()
    {
       inventoryUI.InitializeInventoryUI(inventorySize);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.OpenInventory();
            }
            else
            {
                inventoryUI.HideInventory();
            }
        }
    }
}
