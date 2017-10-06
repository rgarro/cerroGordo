/**
 * la version trigonometrica es la que le corta la pinga al que mato al general ochoa.....
 *  
 *
 * @author Rolando <rgarro@gmail.com>
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunLoader : MonoBehaviour {


	public float moveForce = 0f;
	private Rigidbody rbody;
	public GameObject bullet;
	public float shootRate;
	public float shootForce;
	private float shootRateTime = 0f;
	public GameObject turret;
	public float bulletSpeed;
	public float modelCorrectionAngle;


	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}

	void Update () {
		float rotX = this.transform.localEulerAngles.x + modelCorrectionAngle ;
		Quaternion rotation = Quaternion.Euler(rotX,turret.transform.eulerAngles.y,this.transform.localEulerAngles.z);
		Vector3 position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
		if(Input.GetKey(KeyCode.Space)){
			GameObject go = (GameObject)Instantiate (bullet,position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.velocity = transform.forward * bulletSpeed;
		}
	}
}
