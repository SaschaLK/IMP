using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeSpawner : MonoBehaviour {

    public GameObject toSpawn;
    //public GameObject toSpawn_TOP;
    //public GameObject toSpawn_BOTTOM;
    private int pos;

    public Text text;
    private int spawnedCubes = 0;
    public int spawnRate;
    private int counter = 0;
	// Use this for initialization
	void Start () {
        //pos = Random.Range( - 5, 5);
	}
	
	// Update is called once per frame
    /*
	void FixedUpdate () {
        counter++;
        if( counter == spawnRate)
        {
            pos = Random.Range(-5, 5);
            counter = 0;
            //spawn cube here
            Instantiate(toSpawn, new Vector3(10, pos, 0), Quaternion.identity);
        }
	}
    */
    public void SpawnCube()
    {
        Instantiate(toSpawn, new Vector3(0, 20, 0), Quaternion.identity);
        spawnedCubes++;
        text.text = "Spawned Cubes: " + spawnedCubes;
    }
}
