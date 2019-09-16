using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> items;

    public void AddItem(GameObject newItem)
    {
        items.Add(newItem);
    }

    public void RemoveItem(GameObject itemToRemove)
    {
        items.Remove(itemToRemove);
    }

    public List<GameObject> GetItemList()
    {
        return items;
    }
}
