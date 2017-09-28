/**
 * turns vertically rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @rolando <rolando@emptyart.xyz>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelElevator : MonoBehaviour {

	public string upTurnKey;
	public string downTurnKey;
	public float rotationSteps;
	private AudioSource servoSound;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
	}

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.downTurnKey)){
			this.servoSound.Play ();
			transform.Rotate(Vector3.right * Time.deltaTime * rotationSteps);
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.servoSound.Play ();
			transform.Rotate(Vector3.left * Time.deltaTime * rotationSteps);
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSound.Stop ();
		}
	}
}
