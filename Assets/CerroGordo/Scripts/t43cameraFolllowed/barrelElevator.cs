﻿/**
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
		//this.tPos = this.transform.position;
	}


	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.downTurnKey)){
			this.xRot = (this.xRot - rotationSteps); 
			//Debug.Log (this.xRot);
			Quaternion target = Quaternion.Euler(this.xRot,this.yPivot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
			//transform.Rotate(Vector3.up * Time.deltaTime);
		}
		if(Input.GetKeyDown("c")){
			Quaternion target = Quaternion.Euler(0,this.yPivot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
			//transform.Rotate(Vector3.up * Time.deltaTime);
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			//transform.Rotate(Vector3.down * Time.deltaTime);
			this.xRot = (this.xRot + rotationSteps); 
			Quaternion target = Quaternion.Euler(this.xRot,this.yPivot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
	}
}
