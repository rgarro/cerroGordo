using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliEngine : MonoBehaviour {

	public float rotationSteps;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotate = transform.rotation.y + rotationSteps;
		transform.Rotate(transform.rotation.x,rotate,transform.rotation.x);
	}
}
