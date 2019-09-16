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
    }

    public override void action()
    {

    }
}
