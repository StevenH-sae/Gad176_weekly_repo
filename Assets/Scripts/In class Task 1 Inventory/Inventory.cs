using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Inventory : MonoBehaviour
{
    public List<GameObject> items;
    public GameObject currentItem;
    public int currentSelectedIndex;

    public void UseItem()
    {
        // Does the whole GO exist?
        if (currentItem != null)
        {
            // Does this script exist???
            if (currentItem.GetComponent<IUsable>() != null)
            {
                // YES! Run code
                currentItem.GetComponent<IUsable>().Use();
            }
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        // Is there a component that is an "IUsable" item?
        if (other.gameObject.GetComponent<IUsable>() != null)
        {
            items.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
        
    }
    void Update()
    {
        if (InputSystem.GetDevice<Keyboard>().gKey.wasPressedThisFrame)
        {
            Debug.Log("pressed");
        }
    }
}
