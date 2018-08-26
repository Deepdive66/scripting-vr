using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
  
    AudioSource maudio;

    void Start()
    {
        maudio = GetComponent<AudioSource>();
        maudio.Play(0);
        Debug.Log("started");
    }

    void Update () {
	
        if(Input.GetButtonDown("Jump"))
        {
            if (maudio.isPlaying)
                maudio.Stop();
            else
                maudio.Play();
        }
	}
}
