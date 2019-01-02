using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youcha : MonoBehaviour {
    AudioSource ding;

	// Use this for initialization
	void Start () {
        ding = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider cha)
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        ding.Play(delay: 0);

    }
}
