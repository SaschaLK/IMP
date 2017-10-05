using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string name { get; private set; }
    private Rigidbody rigidBody;
    private Renderer theRenderer;
    public int force;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        theRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Vector3 oldPosition = transform.position;
            //transform.position = new Vector3(oldPosition.x + 0.4f, oldPosition.y, oldPosition.z);

            rigidBody.AddForce(new Vector3(0, force, 0));
        }



    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        theRenderer.material.color = Color.cyan;

    }

    void OnTriggerEnter(Collider other)
    {
        theRenderer.material.color = Color.red;
    }

    void OnTriggerExit(Collider other)
    {
        theRenderer.material.color = Color.green;
    }

}
