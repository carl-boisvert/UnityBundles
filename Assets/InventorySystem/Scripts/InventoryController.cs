using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    private List<Item> items;


    // Use this for initialization
    void Start()
    {
        items = new List<Item>();
    }

	private void OnEnable()
	{
        EventDelegate.ItemPickUp += AddItem;
	}

	private void OnDisable()
	{
        EventDelegate.ItemPickUp -= AddItem;
	}

	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            canvas.enabled = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = false;
        }
    }

    void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log("===================");
        foreach(Item itemModel in items)
        {
            Debug.Log(item.name);
        }
    }

    void ShowInventory()
    {
        
    }
}
