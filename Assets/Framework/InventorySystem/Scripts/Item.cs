using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class Item : ScriptableObject
    {

        [SerializeField]
        private string itemName;

        [SerializeField]
        private Texture2D icon;

        [SerializeField]
        private Mesh itemMesh;

        [SerializeField]
        private int cost;

        [SerializeField]
        private int value;

        [SerializeField]
        private List<Item> ingredients;

        [SerializeField]
        private float weight;

        [SerializeField]
        private Rarity rarity;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Texture2D Icon
        {
            get
            {
                return icon;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
        }

        public List<Item> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public float Weight
        {
            get
            {
                return weight;
            }
        }

        public Mesh ItemMesh
        {
            get
            {
                return itemMesh;
            }
        }

        public Rarity Rarity
        {
            get
            {
                return rarity;
            }
        }
    }
}