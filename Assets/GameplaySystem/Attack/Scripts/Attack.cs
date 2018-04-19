using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snappydue.UnityBundle
{
    abstract public class Attack : ScriptableObject {

        [SerializeField]
        private string attackName;
        [SerializeField]
        private int damage;
        [SerializeField]
        private int range;
        [SerializeField]
        private string status;

        public string AttackName
        {
            get
            {
                return attackName;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int Range
        {
            get
            {
                return range;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
        }
    }
}
