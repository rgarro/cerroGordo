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

	public float minElev;
	public float maxElev;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
		this.gUP = false;
		this.gDown = false;
	}

	void Update () {
		Debug.Log (this.transform.localEulerAngles.x);
		if(Input.GetKeyDown(this.downTurnKey)){
			this.gDown = true;
		}
		if(this.gDown){
			//if (this.transform.localEulerAngles.x > this.minElev) 
				this.soundOn ();
				this.rotateUp ();
			
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gUP = true;
		}
		if(this.gUP){
			//if (this.transform.localEulerAngles.x < this.maxElev)
				this.soundOn ();
				this.rotateDown ();
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSound.Stop ();
			this.resetLed ();
		}
	}

	public void rotateUp(){
		transform.Rotate (Vector3.right * Time.deltaTime * rotationSteps);	
	}

	public void rotateDown(){
		transform.Rotate (Vector3.left * Time.deltaTime * rotationSteps);
	}

	private void soundOn(){
		if (!this.servoSound.isPlaying) {
			this.servoSound.Play ();
		}
	}

	private void resetLed(){
		this.gUP = false;
		this.gDown = false;
	}
}
