/**
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
	public int rotationSteps;
	public float xPivot;
	public float zPivot;
	private float yRot;
	private Vector3 tPos;


	void Start () {
		this.yRot = this.transform.rotation.y;
	}
	

	void Update () {
		//Debug.Log ("here IM is only rocknroll ....");
		if(Input.GetKeyDown(this.leftTurnKey)){
			this.yRot = this.yRot - rotationSteps;
			Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
		if(Input.GetKeyDown(this.rightTurnKey)){
			this.yRot = this.yRot + rotationSteps;
			Quaternion target = Quaternion.Euler(this.xPivot,this.yRot,this.zPivot);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
	}
}
