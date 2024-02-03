using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private UI_Inventory _uiInventory;
    private void Awake()
    {
        _inventory = new Inventory();
        _uiInventory.SetInventory(_inventory);

        ItemWorld.SpawnItemWorld(new Vector3(20, 20), new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(-20, 20), new Item { itemType = Item.ItemType.Sword, amount = 1 });
    }
}
