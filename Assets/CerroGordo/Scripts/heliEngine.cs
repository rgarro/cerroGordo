using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliEngine : MonoBehaviour {

	public float rotationSteps;
	public bool is_z = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(this.is_z){
			float rotate = transform.rotation.z + rotationSteps;
			transform.Rotate(0,0,rotate);
		} else {
			float rotate = transform.rotation.y + rotationSteps;
			transform.Rotate(transform.rotation.x,rotate,transform.rotation.x);
		}
	}
}
