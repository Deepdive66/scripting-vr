using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject snowflake;
    private GameObject[] spawners;

	// Use this for initialization
	void Start () {

        spawners = GameObject.FindGameObjectsWithTag("Spawn");
        InvokeRepeating("Spawn", 1, 1);
	}
	
	// Update is called once per frame
	void Spawn () {

        GameObject spawn = spawners[Random.Range(0, spawners.Length)];
        Instantiate(snowflake, spawn.transform.position, Quaternion.identity);
	}
}
