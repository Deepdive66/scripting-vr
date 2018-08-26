using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeSystem : MonoBehaviour {


    public GameObject Target;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawnobject", 2,1); 
		
	}
	
    void Spawnobject ()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(Target ,new Vector3(x ,2 ,z), Quaternion.identity );
    }
}
