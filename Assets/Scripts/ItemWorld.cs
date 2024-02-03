using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorld : MonoBehaviour
{
    private Item item;
    //private SpriteRenderer spriteRenderer;
    private Image img;
    [SerializeField] private Transform itemContainer;
    public void SpawnItemWorld(Vector2 position, Item item)
    {

        RectTransform transform = (RectTransform)Instantiate(ItemAssets.Instance.prefabItemWorld, itemContainer);
        transform.anchoredPosition = position;
        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);
        //return itemWorld;
    }
    private void Awake()
    {
        //  spriteRenderer= GetComponent<SpriteRenderer>();
        img = GetComponentInChildren<Image>();
    }
    public void SetItem(Item item)
    {

        this.item = item;
        //spriteRenderer.sprite = item.GetSprite();
        img.sprite = item.GetSprite();
    }
    
    
    public Item GetItem() {

        return item;
    }
    public void DestroySelf() {

        Destroy(gameObject);
    }
}
