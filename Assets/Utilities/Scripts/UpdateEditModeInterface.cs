using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEditModeInterface : MonoBehaviour {

    protected GameObject updateInEdit;

    public GameObject Item {
        get { return updateInEdit; }
    }

    public Mesh ItemMesh {
        get { return updateInEdit.GetComponent<Mesh>(); }
    } 
}
