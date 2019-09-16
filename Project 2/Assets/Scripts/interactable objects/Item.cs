using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : InteractableObj
{
    public Sprite sprite;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = sprite;
        SetType(IneractTypeList.ITEM);
    }

    public override void action()
    {
        GameController.instance.player.inventory.AddItem(gameObject);
    }
}
