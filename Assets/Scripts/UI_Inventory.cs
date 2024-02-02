using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private List<Item> inventoryItemList;
    [SerializeField] private Transform _itemSlotContainer;
    [SerializeField] private Transform _itemSlotTemplate;
    //  [SerializeField] private RectTransform _slotContainerRectTransform;

    private void Awake()
    {
        //inventoryItemList = inventory.GetItemList();
    }
    public void SetInventory(Inventory inventory)
    {
        Debug.Log("I am in SetInventory function");
        this.inventory = inventory;
        inventoryItemList = inventory.GetItemList();
        RefreshInventoryItems();
    }
    private void RefreshInventoryItems()
    {
        Debug.Log("I am in RefreshInventoryItems function");
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;
        Debug.Log($"Inventory list count is: {inventoryItemList.Count}");
        foreach (Item item in inventoryItemList)
        {
            //RectTransform itemSlotRectTransform=Instantiate(_itemSlotTemplate,_itemSlotContainer).GetComponent<RectTransform>();
            RectTransform itemSlotRectTransform = (RectTransform)Instantiate(_itemSlotTemplate, _itemSlotContainer);
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }

    }
}
