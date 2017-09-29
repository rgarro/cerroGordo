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
	private bool gUP;
	private bool gDown;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
		this.gUP = false;
		this.gDown = false;
	}

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.downTurnKey)){
			this.gDown = true;
		}
		if(this.gDown){
			if (!this.servoSound.isPlaying) {
				this.servoSound.Play ();
			}
			transform.Rotate(Vector3.right * Time.deltaTime * rotationSteps);
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gUP = true;
		}
		if(this.gUP){
			if (!this.servoSound.isPlaying) {
				this.servoSound.Play ();
			}
			transform.Rotate(Vector3.left * Time.deltaTime * rotationSteps);
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSound.Stop ();
			this.gUP = false;
			this.gDown = false;
		}
	}
}
