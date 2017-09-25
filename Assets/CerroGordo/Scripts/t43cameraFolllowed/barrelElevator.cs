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
	public float yPivot;
	public float zPivot;
	private float xRot;
	private Vector3 tPos;


	void Start () {
		//this.xRot = this.transform.rotation.x;
		this.xRot = 0;
	}


	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.downTurnKey)){
			this.xRot = this.xRot - rotationSteps;
			Quaternion target = Quaternion.Euler(this.xRot,this.yPivot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.xRot = this.xRot + rotationSteps;
			Quaternion target = Quaternion.Euler(this.xRot,this.yPivot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
	}
}
