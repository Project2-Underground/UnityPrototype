using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : InteractableObj
{
    public Vector3 nextPlayerPosition;
    public Vector3 nextCameraPosition;

    public override void action()
    {
        ChangeScene();
    }

    private void ChangeScene()
    {
        // set camera to next scene
        // set player position to next scene
    }
}
