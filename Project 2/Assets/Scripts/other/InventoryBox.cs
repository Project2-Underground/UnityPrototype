using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBox : MonoBehaviour
{
    public Image image;
    private GameObject item;

    public void AddItemToBox(GameObject newItem)
    {
        if (newItem != null)
        {
            item = newItem;
            image.sprite = item.GetComponent<Item>().sprite;
        }
    }

    public void ClearItem()
    {
        item = null;
        image.sprite = null;
    }

    public GameObject getItem()
    {
        return item;
    }

    public void OnClick()
    {

    }
}
