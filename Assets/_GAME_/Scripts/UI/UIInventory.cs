using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIInventory : MonoBehaviour
{
  [SerializeField] UIInventoryItem itemPrefab;
  [SerializeField] RectTransform contentPanel;

  List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();

  public void InitializeInventoryUI(int inventorySize)
  {
    for(int i = 0; i < inventorySize; i++)
    {
        UIInventoryItem uiSlot = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
        uiSlot.transform.SetParent(contentPanel);
        listOfUIItems.Add(uiSlot);
        uiSlot.OnItemClicked += HandleItemSelection;
        uiSlot.OnItemBeginDrag += HandleBeginDrag;
        uiSlot.OnRightMouseBtnClick += HandleShowItemActions;
        uiSlot.OnItemEndDrag += HandleEndDrag;
        uiSlot.OnItemDroppedOn += HandleSwap;
    }
  }

 private void HandleItemSelection(UIInventoryItem item)
    {
        // Handle item selection
    }

    private void HandleBeginDrag(UIInventoryItem item)
    {
        // Handle begin drag
    }

    private void HandleShowItemActions(UIInventoryItem item)
    {
        // Handle show item actions
    }

    private void HandleEndDrag(UIInventoryItem item)
    {
        // Handle end drag
    }

    private void HandleSwap(UIInventoryItem item)
    {
        // Handle swap
    }

  public void OpenInventory()
  {
    gameObject.SetActive(true);
  }
  
  public void HideInventory()
  {
    gameObject.SetActive(false);
  }
}
