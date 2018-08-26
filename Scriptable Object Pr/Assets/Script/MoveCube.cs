using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public Rigidbody rb;

    private bool move = false;
    private  float t = 0.0f;


	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}
