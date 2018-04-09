using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipement : Item
{

    [SerializeField]
    private int durability;

    public int Durability
    {
        get
        {
            return durability;
        }
    }
}
