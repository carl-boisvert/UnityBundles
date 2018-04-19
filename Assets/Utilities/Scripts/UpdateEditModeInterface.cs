using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class UpdateEditModeInterface : MonoBehaviour
    {

        protected GameObject updateInEdit;

        public GameObject Item
        {
            get { return updateInEdit; }
        }

        public Mesh ItemMesh
        {
            get { return updateInEdit.GetComponent<Mesh>(); }
        }
    }
}