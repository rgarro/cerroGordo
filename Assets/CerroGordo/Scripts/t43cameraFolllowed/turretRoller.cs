﻿/**
 * turns horizontally rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @rolando <rolando@emptyart.xyz>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretRoller : MonoBehaviour {

	public string leftTurnKey;
	public string rightTurnKey;
	public float rotationSteps;
	public float xPivot;
	public float zPivot;
	private float yRot;
	private Vector3 tPos;


	void Start () {
		this.yRot = this.transform.rotation.y;
	}
	//ojo la turreta viene torcida de ukrania para torcer los cables de detonar la municion

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.leftTurnKey)){
			this.yRot = this.yRot - rotationSteps;
			Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
			//transform.Rotate(Vector3.left * Time.deltaTime * rotationSteps);///la 
		}
		if(Input.GetKeyDown(this.rightTurnKey)){
			//transform.Rotate(Vector3.right * Time.deltaTime * rotationSteps);
			this.yRot = this.yRot + rotationSteps;
			Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
	}
}
