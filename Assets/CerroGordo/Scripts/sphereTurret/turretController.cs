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
	private float rot = 0.0f;
	private float elev = 0.0f;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
		this.gUP = false;
		this.gDown = false;
		this.gRight = false;
		this.gLeft = false;
	}
	

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");

		if(Input.GetKeyDown(this.downTurnKey)){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}
			this.gDown = true;
		}
		if(this.gDown){
			elev += elevationSteps  * Time.deltaTime;
			//transform.Rotate(Vector3.right  * elevationSteps * Time.deltaTime);
			transform.Rotate(-elev,0,0);

		}
		if(Input.GetKeyDown(this.upTurnKey)){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}
			this.gUP = true;
		}
		if(this.gUP){
			//transform.Rotate(Vector3.left  * elevationSteps * Time.deltaTime);
			elev -= elevationSteps  * Time.deltaTime;
			transform.Rotate(elev,0, 0);
		}
		if(Input.GetKeyDown(this.rightTurnKey)){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}
			this.gRight = true;
			rot += rotationSteps  * Time.deltaTime;
		}
		if(this.gRight){
			//transform.Rotate(Vector3.up  * rotationSteps * Time.deltaTime);
			transform.Rotate(0, rot, 0);
		}
		if(Input.GetKeyDown(this.leftTurnKey)){
			this.gLeft = true;
			rot -= rotationSteps  * Time.deltaTime;
		}
		if(this.gLeft){
			if (play_servo) {
				if (!this.servoSound.isPlaying) {
					this.servoSound.Play ();
				}
			}

			//transform.Rotate(Vector3.down  * (-1 *rotationSteps) * Time.deltaTime);
			transform.Rotate(0, rot, 0);
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
