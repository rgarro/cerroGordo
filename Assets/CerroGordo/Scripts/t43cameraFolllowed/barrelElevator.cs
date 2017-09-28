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

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");

		if(Input.GetKeyDown(this.downTurnKey)){
			transform.Rotate(Vector3.right * Time.deltaTime * rotationSteps);
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			transform.Rotate(Vector3.left * Time.deltaTime * rotationSteps);
		}
	}
}
