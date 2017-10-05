using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float movementSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y, currentPosition.z);
	}
}
