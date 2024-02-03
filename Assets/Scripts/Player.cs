using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private UI_Inventory _uiInventory;
    [SerializeField] private ItemWorld _itemWorld;
    private void Start()
    {
        _inventory = new Inventory();
        _uiInventory.SetInventory(_inventory);
        //Debug.Log(_inventory.itemList.Count);
        _itemWorld.SpawnItemWorld(new Vector2(0, 100), new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        _itemWorld.SpawnItemWorld(new Vector2(0, 200), new Item { itemType = Item.ItemType.Sword, amount = 1 });
    }
    public void AddItemToInventory() {
        
        //if (_itemWorld != null) {
            Debug.Log("Add item to inventory on click is being called");
            _inventory.AddItem(_itemWorld.GetItem());
            //Debug.Log(_inventory.itemList.Count);
            _uiInventory.SetInventory(_inventory);
           // _itemWorld.DestroySelf();
        //}
    }
}
