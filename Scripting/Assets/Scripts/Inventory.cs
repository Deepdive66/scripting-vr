using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{


    public class stuff
    {

        public int bullets;
        public int granades;
        public int rockets;
        public float fuel;


        public stuff(int bul, int grd, int rckt)
        {

            bullets = bul;
            granades = grd;
            rockets = rckt;
        }

        public stuff (int bul,float ful){
            bullets = bul;
            fuel = ful;
        }

    }

    public stuff mystuff = new stuff(50,5,3);

    public stuff myotherstuff = new stuff(50, 5.3f);

	// Use this for initialization
	void Start () {

        Debug.Log(mystuff.bullets);
        Debug.Log(myotherstuff.fuel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
