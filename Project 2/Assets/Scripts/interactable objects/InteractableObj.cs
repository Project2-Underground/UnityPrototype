using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IneractTypeList { HUMAN, ITEM, PUZZLE, PORTAL };

abstract public class InteractableObj : MonoBehaviour
{
    // default type = ITEM
    IneractTypeList ineractType = IneractTypeList.ITEM;

    //abstract method
    public abstract void action();

    public void SetType(IneractTypeList newInteractType)
    {
        ineractType = newInteractType;
    }
}
