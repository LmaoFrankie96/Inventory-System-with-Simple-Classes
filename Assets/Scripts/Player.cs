using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private UI_Inventory _uiInventory;
    private void Awake()
    {
        //Debug.Log("I am running 1");
        _inventory = new Inventory();
       // Debug.Log("I am running 2");
        _uiInventory.SetInventory(_inventory);
        //Debug.Log("I am running 3");
    }
}
