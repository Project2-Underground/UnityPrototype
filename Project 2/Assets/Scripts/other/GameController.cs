using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Player player;
    public Camera gameCamera;
    public SoundManager soundManager;
    public Fading fade;

    public List<GameObject> displayInventory;

    public SpriteRenderer spriteRenderer;
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

    public void UpdateDisplayInventory()
    {
        /* get items from player's inventory
         * distritbute item to available slot
         */
        for (int i = 0; i < displayInventory.Count; i++)
        {
            displayInventory[i].GetComponent<SpriteRenderer>().sprite = null;
        }
        List<GameObject> items = player.inventory.GetItemList();
        for(int i = 0; i < items.Count; i++)
        {
            // displayInventory[i].GetComponent<SpriteRenderer>().sprite = items[i].GetComponent<Item>().sprite;
            continue;
        }
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
