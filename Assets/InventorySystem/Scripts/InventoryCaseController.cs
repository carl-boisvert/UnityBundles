using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCaseController : MonoBehaviour {

    [SerializeField]
    private RawImage icon;
    [SerializeField]
    private RawImage border;
    private Item item = null;

    public Item Item
    {
        get
        {
            return item;
        }

        set
        {
            item = value;
        }
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(item != null)
        {
            icon.texture = item.Icon;
            icon.color = Color.white;
            border.color = item.Rarity.Material.color;
        }
	}
}
