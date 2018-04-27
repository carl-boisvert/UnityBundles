using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MinimapCameraController : MonoBehaviour {

    [SerializeField]
    private float cameraDistance = 5.0f;
    private Camera camera;
    private Transform playerPosition;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        camera.transform.position = playerPosition.position + new Vector3(0, cameraDistance, 0);
        camera.transform.LookAt(playerPosition);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
