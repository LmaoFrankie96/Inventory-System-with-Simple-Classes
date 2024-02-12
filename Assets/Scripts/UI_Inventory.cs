using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory _inventory;
    
    [SerializeField] private Transform _itemSlotContainer;
    [SerializeField] private Transform _itemSlotTemplate;
    [SerializeField] private Image _itemImage;
    

    public void SetInventory(Inventory inventory)
    {
        this._inventory = inventory;
        _inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Transform child in _itemSlotContainer) {

            if (child == _itemSlotTemplate) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 200f;
        foreach (Item item in _inventory.itemList)
        {
            
            _itemImage.sprite=item.GetSprite();
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
    
}
