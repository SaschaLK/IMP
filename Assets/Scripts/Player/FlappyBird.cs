using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour {

    public Vector3 jumpForce;
    private Rigidbody rigidBody;


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(jumpForce);
        }
	}
}
