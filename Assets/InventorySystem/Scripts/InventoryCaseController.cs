using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public partial class EventDelegate
{
    public delegate void OnItemClickedHandler(Item item);
    public static event OnItemClickedHandler ItemClicked;
    public static void OnItemClicked(Item item)
    {
        if(ItemClicked != null)
        {
            ItemClicked(item);
        }
    }
}

public class InventoryCaseController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    [SerializeField]
    private RawImage icon;
    [SerializeField]
    private RawImage border;
    private Item item = null;
    private bool equiped = false;

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
        if (item != null && !equiped)
        {
            border.color = Color.white;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null && !equiped)
        {
            border.color = item.Rarity.Material.color;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (item != null && !equiped)
        {
            equiped = true;
            border.color = Color.white;
            EventDelegate.OnItemClicked(item);
        }
    }
}
