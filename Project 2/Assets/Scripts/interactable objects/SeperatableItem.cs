using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeperatableItem : Item
{
    public CombinableObj seperatedPart1;
    public CombinableObj seperatedPart2;

    public void SeperateItem()
    {
        GameController.instance.player.inventory.AddItem(seperatedPart1.gameObject);
        GameController.instance.player.inventory.AddItem(seperatedPart2.gameObject);
        GameController.instance.player.inventory.RemoveItem(gameObject);
    }
}
