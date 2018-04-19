using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "Item", menuName = "Items/Grenade", order = 1)]
    public class Grenade : Consumable
    {

        [SerializeField]
        private int damage;
    }
}