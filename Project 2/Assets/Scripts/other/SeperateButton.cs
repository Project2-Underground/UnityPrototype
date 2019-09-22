using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeperateButton : itemButton
{
    // drag and drop separation item
    private GameObject item;
    public override void DropItem(GameObject newItem)
    {
        item = newItem;
        action();
        item = null;
    }

    public override void action()
    {
        GameController.instance.player.inventory.SeperateItem(item);
    }
}
