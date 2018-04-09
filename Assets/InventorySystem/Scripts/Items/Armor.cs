using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Armor", order = 2)]
public class Armor : Equipement {

    [SerializeField]
    private int defence;
}
