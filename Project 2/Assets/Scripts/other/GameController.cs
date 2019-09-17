using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Player player;
    public Camera gameCamera;
    public SoundManager soundManager;
    public Fading fade;

    public List<InventoryBox> displayInventory;

    private GameObject selectedItem1;
    private GameObject selectedItem2;

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
        // clear items in inventory
        for(int i=0;i< displayInventory.Count; i++)
        {
            displayInventory[i].ClearItem();
        }

        List<GameObject> items = player.inventory.GetItemList();
        if (items != null)
        {
            for (int i = 0; i < items.Count; i++)
            {
                displayInventory[i].AddItemToBox(items[i]);
            }
        }
    }

    public void SelectItem(InventoryBox itemBox)
    {
        if(selectedItem2 != null)
        {
            selectedItem1 = null;
            selectedItem2 = null;
            Debug.Log("selections clear");
        }

        if(selectedItem1 == null)
        {
            selectedItem1 = itemBox.getItem();
            Debug.Log("selection item 1 : " + selectedItem1);
        }
        else
        {
            selectedItem2 = itemBox.getItem();
            Debug.Log("selection item 2 : " + selectedItem2);
        }

    }

    public void SeperateItem()
    {
        if(selectedItem1 != null)
        {
            player.inventory.SeperateItem(selectedItem1);
            selectedItem1 = null;
        }
        else
        {
            Debug.Log("no item selected");
        }
    }

    public void CombineItem()
    {
        if (selectedItem1 != null && selectedItem2 != null)
        {
            player.inventory.CombineItems(selectedItem1, selectedItem2);
        }
        else
        {
            Debug.Log("not enough items selected");
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
