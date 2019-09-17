using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinableObj : Item
{
    public SeperatableItem combinedItem;
    public CombinableObj partToCombine;

    public bool CombineObject(CombinableObj part)
    {
        /* return true if combinable
         * false if not combinable
         */
        if (partToCombine == part)
        {
            GameController.instance.player.inventory.AddItem(combinedItem.gameObject);
            GameController.instance.player.inventory.RemoveItem(part.gameObject);
            GameController.instance.player.inventory.RemoveItem(gameObject);
            return true;
        }
        return false;
    }
}
