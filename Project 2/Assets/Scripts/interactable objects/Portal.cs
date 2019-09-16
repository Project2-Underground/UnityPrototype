using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : InteractableObj
{
    public Vector3 nextPlayerPosition;
    public Vector3 nextCameraPosition;

    private bool startFade;

    void Start()
    {
        startFade = false;
        SetType(IneractTypeList.PORTAL);
    }

    void Update()
    {
        if (startFade && GameController.instance.fade.FadeEnd())
        {
            ChangeScene();
            GameController.instance.fade.Fade();
            startFade = false;
        }
    }

    public override void action()
    {
        GameController.instance.fade.Fade();
        startFade = true;
    }

    private void ChangeScene()
    {
        // set camera to next scene
        // set player position to next scene
    }
}
