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

        _itemWorld.SpawnItemWorld(new Vector2(0, 0), new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        _itemWorld.SpawnItemWorld(new Vector2(0, 20), new Item { itemType = Item.ItemType.Sword, amount = 1 });
    }
}
