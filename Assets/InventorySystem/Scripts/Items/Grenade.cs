using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Grenade", order = 1)]
public class Grenage : Consumable {

    [SerializeField]
    private int damage;
}
