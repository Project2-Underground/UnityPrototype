using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class itemButton : MonoBehaviour
{
    // for implementing drag and drop combination and separation items
    public abstract void DropItem(GameObject newItem);
    public abstract void action();
}
