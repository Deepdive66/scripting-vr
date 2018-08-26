using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponent : MonoBehaviour {

    public GameObject other;
    //private Light mylight;
	// Use this for initialization
	void Start () {
        //mylight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            // mylight.enabled = !mylight.enabled; 
            Destroy(other,3f);
        }
	}
}
