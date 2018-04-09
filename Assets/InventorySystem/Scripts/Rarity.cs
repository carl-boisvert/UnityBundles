using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rarity", menuName = "Rarity")]
public class Rarity : ScriptableObject {

    [SerializeField]
    private string name;

    [SerializeField]
    private Material material;

    public string Name
    {
        get
        {
            return name;
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
