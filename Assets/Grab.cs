using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
    bool isgrab;
    void Grabbing()
    {
        isgrab = true;
    }
    void Dropping()
    {
        isgrab = false;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
