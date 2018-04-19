using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "Rarity", menuName = "Rarity")]
    public class Rarity : ScriptableObject
    {

        [SerializeField]
        private string rarityName;

        [SerializeField]
        private Material material;

        public string Name
        {
            get
            {
                return rarityName;
            }
        }

        public Material Material
        {
            get
            {
                return material;
            }
        }
    }
}