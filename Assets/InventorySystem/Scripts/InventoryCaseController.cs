using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class InventoryCaseController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

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

    public void updateView()
    {
        icon.texture = item.Icon;
        icon.color = Color.white;
        border.color = item.Rarity.Material.color;
    }

    private void OnMouseEnter()
    {
        Debug.Log("Hover on " + item.name + " item");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            border.color = Color.white;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null)
        {
            border.color = item.Rarity.Material.color;
        }
    }
}
