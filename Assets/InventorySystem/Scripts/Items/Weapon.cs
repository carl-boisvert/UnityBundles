using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Weapon", order = 3)]
public class Weapon : Equipement
{

    [SerializeField]
    private int attack;
}
