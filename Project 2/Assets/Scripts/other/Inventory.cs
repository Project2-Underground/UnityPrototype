using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    public void AddItem(Item newItem)
    {
        items.Add(newItem);
    }

    public void RemoveItem(Item itemToRemove)
    {
        items.Remove(itemToRemove);
    }

    public List<Item> GetItemList()
    {
        return items;
    }
}
