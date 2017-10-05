﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Accelerate"))
        {
            Time.timeScale *= 2;
        }
        if (Input.GetButtonDown("SlowDown"))
        {
            Time.timeScale /= 2;
        }
	}

    public void SetTime(float value)
    {
        Time.timeScale = value;
    }
}
