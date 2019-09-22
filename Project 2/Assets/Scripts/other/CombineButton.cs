using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineButton : itemButton
{
    // drag and drop combination items
    private GameObject[] item = new GameObject[2];
    private int itemIndex = 0;
    public override void DropItem(GameObject newItem)
    {
        item[itemIndex] = newItem;
        itemIndex++;
        if (itemIndex == 2)
        {
            // when drop all 2 item, it will call combine item for the player
            action();
            // reset
            item[0] = null;
            item[1] = null;
            itemIndex = 0;
        }
    }
    public override void action()
    {
        GameController.instance.player.inventory.CombineItems(item[0], item[1]);
    }
}
