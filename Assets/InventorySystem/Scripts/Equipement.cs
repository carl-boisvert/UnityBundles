using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
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
}