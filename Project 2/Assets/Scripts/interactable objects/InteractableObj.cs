using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IneractTypeList { NPC, ITEM, PUZZLE, PORTAL };

abstract public class InteractableObj : MonoBehaviour
{
    // default type = ITEM
    IneractTypeList interactType = IneractTypeList.ITEM;

    //abstract method
    public virtual void action() {

    }

    public void SetType(IneractTypeList newInteractType)
    {
        interactType = newInteractType;
    }

    public IneractTypeList SetType()
    {
        return interactType;
    }
}
