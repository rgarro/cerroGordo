using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverB : MonoBehaviour {

	public float speed;

	void Start ()
	{
		//transform.Rotate(0, 180, 0);
		GetComponent<Rigidbody>().velocity = transform.forward * speed;

	}
}
