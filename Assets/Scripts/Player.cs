using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class Player : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private UI_Inventory _uiInventory;
    public GameObject[] itemButtons;
    public int itemFlag;
    public GameObject inventoryFullPopUp;
    private void Start()
    {
        _inventory = new Inventory();
        _uiInventory.SetInventory(_inventory);
        itemFlag = 0;
    }
    public void AddItemToInventory()
    {
        if (_inventory.itemList.Count < 16)
        {
            if (itemFlag == 0)
            {

                _inventory.AddItem(new Item(ItemType.HealthPotion, 1, _inventory.itemList.Count));
            }
            else if (itemFlag == 1)
            {
                _inventory.AddItem(new Item(ItemType.Sword, 1, _inventory.itemList.Count));

            }
            else if (itemFlag == 2)
            {
                _inventory.AddItem(new Item(ItemType.Coin, 1, _inventory.itemList.Count));

            }
            else if (itemFlag == 3)
            {
                _inventory.AddItem(new Item(ItemType.Medkit, 1, _inventory.itemList.Count));

            }
        }
        else {
            inventoryFullPopUp.SetActive(true);
        }

    }
    public void SetItemFlag(int flag)
    {
        itemFlag = flag;

    }
    public void RemoveItemFromInventory()
    {
        _inventory.RemoveItem(_inventory.itemList[_inventory.itemList.Count - 1]);

    }
}
