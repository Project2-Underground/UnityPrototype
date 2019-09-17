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

    public void SeperateItem(GameObject item)
    {
        SeperatableItem sepItem = item.GetComponent<Item>() as SeperatableItem;
        if (sepItem != null)
        {
            sepItem.SeperateItem();
            GameController.instance.UpdateDisplayInventory();
        }
        else
        {
            Debug.Log("this item cannot be seperated");
        }
    }

    public void CombineItems(GameObject item1, GameObject item2)
    {
        CombinableObj comItem1 = item1.GetComponent<Item>() as CombinableObj;
        CombinableObj comItem2 = item2.GetComponent<Item>() as CombinableObj;
        if(comItem1 != null && comItem2 != null)
        {
            if (comItem1.CombineObject(comItem2))
            {
                Debug.Log("combine sucessful");
                GameController.instance.UpdateDisplayInventory();
            }
            else
            {
                Debug.Log("combine fail");
            }
        }
        else
        {
            Debug.Log("items cannot be combined");
        }
    }

    public List<GameObject> GetItemList()
    {
        if(items.Count == 0)
        {
            return null;
        }
        return items;
    }
}
