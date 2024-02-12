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
        itemFlag = 0;
    }
    public void AddItemToInventory() {
        if (itemFlag == 0) {

            _inventory.AddItem(new Item(Item.ItemType.HealthPotion,1,_inventory.itemList.Count));
           Debug.Log(_inventory.itemList[_inventory.itemList.Count - 1].itemKey);
        }
        else if (itemFlag == 1)
        {
            _inventory.AddItem(new Item(Item.ItemType.Sword, 1, _inventory.itemList.Count));
            Debug.Log(_inventory.itemList[_inventory.itemList.Count - 1].itemKey);

        }
        else if (itemFlag == 2)
        {
            _inventory.AddItem(new Item(Item.ItemType.Coin, 1, _inventory.itemList.Count));
            Debug.Log(_inventory.itemList[_inventory.itemList.Count - 1].itemKey);

        }
        else if (itemFlag == 3)
        {
            _inventory.AddItem(new Item(Item.ItemType.Medkit, 1, _inventory.itemList.Count));
            Debug.Log(_inventory.itemList[_inventory.itemList.Count - 1].itemKey);

        }
       
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
