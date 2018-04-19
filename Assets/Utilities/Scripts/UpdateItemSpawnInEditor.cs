using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class UpdateItemSpawnInEditor : MonoBehaviour
    {

        private Item item = null;
        private MeshFilter meshFilter = null;
        private MeshRenderer meshRenderer = null;

        private void Start()
        {
            meshFilter = gameObject.GetComponent<MeshFilter>();
            meshRenderer = gameObject.GetComponent<MeshRenderer>();
            Debug.Log("Start Finished");
        }

        // Update is called once per frame
        void Update()
        {
            if (GetComponent<ItemSpawnController>() != null)
            {
                item = GetComponent<ItemSpawnController>().item;
            }
            if (item != null)
            {
                meshFilter.sharedMesh = item.ItemMesh;
                meshRenderer.material = item.Rarity.Material;
            }

        }
    }
}