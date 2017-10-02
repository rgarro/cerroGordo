/**
 * turret sphere template controller
 
 * 
 * @rolando <rolando@emptyart.xyz>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour {

	public string upTurnKey;
	public string downTurnKey;
	public float rotationSteps;
	private bool gUP;
	private bool gDown;
	public float elevationSteps;
	public string leftTurnKey;
	public string rightTurnKey;
	private bool gRight;
	private bool gLeft;
	private AudioSource servoSound;
	public bool play_servo = false;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
		this.gUP = false;
		this.gDown = false;
		this.gRight = false;
		this.gLeft = false;
	}
	

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.rightTurnKey)){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}
			this.gRight = true;
		}
		if(this.gRight){
			transform.Rotate(Vector3.up  * rotationSteps);
		}
		if(Input.GetKeyDown(this.leftTurnKey)){
			this.gLeft = true;
		}
		if(this.gLeft){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}

			transform.Rotate(Vector3.down  * rotationSteps);
		}
		if (Input.GetKeyUp (this.leftTurnKey) || Input.GetKeyUp(this.rightTurnKey)) {
			if (play_servo) {
				this.servoSound.Stop ();
			}
			this.gLeft = false;
			this.gRight = false;

		}
		if (Input.GetKeyUp (this.upTurnKey) || Input.GetKeyUp(this.downTurnKey)) {
			this.gUP = false;
			this.gDown = false;
			if (play_servo) {
				this.servoSound.Stop ();
			}
		}
	}
}
