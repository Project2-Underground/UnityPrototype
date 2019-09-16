using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : InteractableObj
{
    // Start is called before the first frame update
    void Start()
    {
        SetType(IneractTypeList.NPC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void action()
    {

    }
}
