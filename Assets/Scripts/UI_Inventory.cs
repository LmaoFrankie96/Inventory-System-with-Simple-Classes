using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory _inventory;
    private List<Item> inventoryItemList;
    [SerializeField] private Transform _itemSlotContainer;
    [SerializeField] private Transform _itemSlotTemplate;
    [SerializeField] private Image _itemImage;
    //  [SerializeField] private RectTransform _slotContainerRectTransform;

    private void Awake()
    {
        //inventoryItemList = _inventory.GetItemList();
    }
    public void SetInventory(Inventory inventory)
    {
        //Debug.Log("I am in SetInventory function");
        this._inventory = inventory;
        inventoryItemList = _inventory.GetItemList();
        _inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, EventArgs e)
    {
        inventoryItemList = _inventory.GetItemList();
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Transform child in _itemSlotContainer) {

            if (child == _itemSlotTemplate) continue;
            Destroy(child.gameObject);
        }
        //Debug.Log("I am in RefreshInventoryItems function");
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 200f;
        //Debug.Log($"Inventory list count is: {inventoryItemList.Count}");
        foreach (Item item in inventoryItemList)
        {
            //RectTransform itemSlotRectTransform=Instantiate(_itemSlotTemplate,_itemSlotContainer).GetComponent<RectTransform>();
            Debug.Log($"I am item number: {inventoryItemList.IndexOf(item)}");
            //Debug.Log($"I am item number: {inventoryItemList[inventoryItemList.IndexOf(item)].GetSprite().name}");
           // _itemImage.sprite=item.GetSprite();
            RectTransform itemSlotRectTransform = (RectTransform)Instantiate(_itemSlotTemplate, _itemSlotContainer);
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 3)
            {
                x = 0;
                y--;
            }
        }

    }
    /*public void AddItemToInventory() { 
    
        
    }*/
}
