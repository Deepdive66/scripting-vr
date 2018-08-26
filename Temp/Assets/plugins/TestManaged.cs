using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManaged : MonoBehaviour {

	void Start () {

        RandomNumber.MyClass.obj = new RandomNumber.MyClass();
	}

}
