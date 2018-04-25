using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public partial class EventDelegate
    {

        public delegate void ItemPickUpHandler(Item item);
        public static event ItemPickUpHandler ItemPickUp;
        public static void OnItemPickUp(Item item)
        {
            if (ItemPickUp != null)
            {
                ItemPickUp(item);
            }
        }
    }

    [RequireComponent(typeof(UpdateItemSpawnInEditor), typeof(SphereCollider))]
    public class ItemSpawnController : MonoBehaviour
    {


        public Item item = null;
        private SphereCollider itemCollider;


        // Use this for initialization
        void Start()
        {
            itemCollider = gameObject.GetComponent<SphereCollider>();
            itemCollider.isTrigger = true;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            EventDelegate.OnItemPickUp(item);
            Destroy(gameObject);
        }
    }
}