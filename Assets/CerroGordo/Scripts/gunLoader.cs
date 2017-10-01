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


	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}

	void Update () {
		
		float x = this.transform.position.x * moveForce * Time.deltaTime;
		float y = this.transform.position.y * moveForce * Time.deltaTime;
		float z = this.transform.position.z * moveForce * Time.deltaTime;
		Vector3 rbg = new Vector3(x,y,z);
		if(Input.GetKey(KeyCode.Space)){
			GameObject go = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.AddForce (rbg);
		}
	}
}
