using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class Player : NetworkBehaviour
    {

        [SerializeField]
        private string username;
        [SerializeField]
        private GameObject body;

        private static Color[] colors = { Color.blue, Color.red, Color.green, Color.yellow };
        private static int playerNumber = 0;



        // Use this for initialization
        void Start()
        {
            body.GetComponent<Renderer>().material.color = colors[playerNumber];
            playerNumber++;
        }

        // Update is called once per frame
        void Update()
        {
            if (!isLocalPlayer)
            {
                return;
            }

            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }

        public string Username
        {
            get { return username; }
        }
    }
}