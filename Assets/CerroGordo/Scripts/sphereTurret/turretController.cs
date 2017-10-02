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

	void Start () {
		this.gUP = false;
		this.gDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
