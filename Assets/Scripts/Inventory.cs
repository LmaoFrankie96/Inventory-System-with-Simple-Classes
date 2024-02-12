using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<Item> itemList;
    public event EventHandler OnItemListChanged;
   
    public Inventory()
    {
        itemList = new List<Item>();
        AddItem(new Item(Item.ItemType.Sword, 1, itemList.Count ));
        AddItem(new Item(Item.ItemType.HealthPotion, 1, itemList.Count));
        AddItem(new Item(Item.ItemType.ManaPotion, 1, itemList.Count));
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }
    public void RemoveItem(Item item)
    {
        itemList.Remove(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);

    }
    public List<Item> GetItemList() { 
    
        return itemList;
    }
}
