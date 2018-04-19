using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "Item", menuName = "Items/Potion", order = 4)]
    public class Potion : Consumable
    {

        [SerializeField]
        private int consumption;
    }
}