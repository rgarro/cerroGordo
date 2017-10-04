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


	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}

	void Update () {
		Debug.Log ("rot " + turret.transform.rotation.z);
		Debug.Log ("local " + turret.transform.localRotation.z);
		Debug.Log ("eulerz " + turret.transform.eulerAngles.z);
		Debug.Log ("eulerx " + turret.transform.eulerAngles.x);
		Debug.Log ("eulery " + turret.transform.eulerAngles.y);//
		/*
float x = this.transform.position.x * moveForce * Time.deltaTime;
		float y = this.transform.position.y * moveForce * Time.deltaTime;
		float z = this.transform.position.z * moveForce * Time.deltaTime;
		*/
		float x = this.transform.position.x * moveForce;
		float y = this.transform.position.y * moveForce;
		float z = this.transform.position.z * moveForce;
		//Quaternion rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y * Time.deltaTime, turret.transform.rotation.z* Time.deltaTime);
		Quaternion rotation = Quaternion.Euler(transform.rotation.x,turret.transform.rotation.z , transform.rotation.z );
		Debug.Log (rotation);
		Vector3 rbg = new Vector3(x,y,z);
		Vector3 position = new Vector3(this.transform.position.x,this.transform.position.y + 2,this.transform.position.z);
		if(Input.GetKey(KeyCode.Space)){
			GameObject go = (GameObject)Instantiate (bullet,position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.AddForce (rbg);
		}
	}
}
