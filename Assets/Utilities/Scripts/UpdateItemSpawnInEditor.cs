using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UpdateItemSpawnInEditor : MonoBehaviour {

    [SerializeField]
    private Item item= null;
    private MeshFilter meshFilter = null;
    private MeshRenderer meshRenderer = null;
    

    // Update is called once per frame
    void Update() {
        if (GetComponent<ItemSpawnController>() != null)
        {
            item = GetComponent<ItemSpawnController>().item;
        }
        if (item != null)
        {
            if (meshFilter == null)
            {
                meshFilter = gameObject.AddComponent<MeshFilter>();

            }
            meshFilter.sharedMesh = item.ItemMesh;

            if (meshRenderer == null)
            {
                meshRenderer = gameObject.AddComponent<MeshRenderer>();
            }
            meshRenderer.material = item.Rarity.Material;
        }
        
    }
}
