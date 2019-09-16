using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    /* keep things as player, camera
     * so that we can call anything from this instead of finding it 
     */
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        MouseInput();
    }

    private void MouseInput()
    {
        // check mouse input
        /* if mouse1 
         * check if clicks object
         * adjust player's pos (is far away)
         * calls obj's action
         */

        /* if mouse2        
         * change player's pos to clicked pos
         */
    }
}
