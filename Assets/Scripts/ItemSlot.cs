using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image itemImage;

    public void SetItem(Item item, Sprite sprite)
    {
        itemImage.sprite = sprite;
    }
}