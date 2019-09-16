using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        
    }

    public void Fade()
    {
        // anim.SetTrigger("startFade");
    }

    public bool FadeEnd()
    {
        /* if in fading animation
         * return false
         * else 
         * return true
         */
        return true;
    }
}
