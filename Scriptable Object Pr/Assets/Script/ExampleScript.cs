using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class ExampleScript : MonoBehaviour {

   public Transform  myTransform;
    private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //    myTransform.position = Vector3.up * Time.time;

        myRigidbody.AddForce(Vector3.up * 40);
	}
}
