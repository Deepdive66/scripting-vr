using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public float movespeed = 10f;
    public float turnspeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime); 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate (Vector3.up * turnspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow ))
        {
            transform.Rotate (Vector3.up   * -turnspeed * Time.deltaTime);
        }
       /* if (Input.GetKeyDown(KeyCode.R)){
            GetComponent<Renderer>().material.color = Color.red;
        }	
        if(Input.GetKeyDown(KeyCode.G)){
            GetComponent<Renderer>().material.color = Color.green;
        }
        if(Input.GetKeyDown(KeyCode.B)){
            GetComponent<Renderer>().material.color = Color.blue;
        }*/
	}
}
