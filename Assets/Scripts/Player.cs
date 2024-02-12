using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private UI_Inventory _uiInventory;
    //[SerializeField] private ItemWorld _itemWorld;
    public GameObject[] itemButtons;
    public int itemFlag;
    private void Start()
    {
        _inventory = new Inventory();
        foreach (var item in _inventory.itemList)
            Debug.Log($"Item key is: {item.itemKey}");
        _uiInventory.SetInventory(_inventory);
        //Debug.Log(_inventory.itemList.Count);
       /* _itemWorld.SpawnItemWorld(new Vector2(0, 100), new Item { itemType = Item.ItemType.ManaPotion, amount = 1, itemKey = _inventory.itemList.Count - 1 });
        _itemWorld.SpawnItemWorld(new Vector2(0, 200), new Item { itemType = Item.ItemType.Sword, amount = 1, itemKey = _inventory.itemList.Count - 1 });*/
        itemFlag = 0;
    }
    public void AddItemToInventory() {
        if (itemFlag == 0) {

            _inventory.AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1, itemKey = _inventory.itemList.Count - 1 });
            //Debug.Log(_inventory.itemList[_inventory.itemList.Count - 1].itemType);
        }
        else if (itemFlag == 1)
        {
            _inventory.AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1, itemKey = _inventory.itemList.Count - 1 });

        }
        else if (itemFlag == 2)
        {
            _inventory.AddItem(new Item { itemType = Item.ItemType.Coin, amount = 1, itemKey = _inventory.itemList.Count - 1 });

        }
        else if (itemFlag == 3)
        {
            _inventory.AddItem(new Item { itemType = Item.ItemType.Medkit, amount = 1, itemKey = _inventory.itemList.Count - 1 });

        }
        //if (_itemWorld != null) {
        //Debug.Log("Add item to inventory on click is being called");
        //_inventory.AddItem(_itemWorld.GetItem());
        // Debug.Log($"Item key is: {_inventory.itemList[_inventory.itemList.Count-1].itemKey}");
        //Debug.Log(_inventory.itemList.Count);
        //_uiInventory.SetInventory(_inventory);
        // _itemWorld.DestroySelf();
        //}
    }
    public void SetItemFlag(int flag)
    {
        itemFlag=flag;

    }
    public void RemoveItemFromInventory()
    {
        Debug.Log("Remove item from inventory on click is being called");
        _inventory.RemoveItem(_inventory.itemList[_inventory.itemList.Count-1]);

    }
}
