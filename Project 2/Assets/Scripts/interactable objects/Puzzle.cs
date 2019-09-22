using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : InteractableObj
{
    private bool solved;
    // Start is called before the first frame update
    void Start()
    {
        solved = false;
        SetType(IneractTypeList.PUZZLE);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void action()
    {

    }

    public void Open()
    {

    }

    public void Close()
    {

    }

    public virtual void CheckPuzzle()
    {

    }
}
