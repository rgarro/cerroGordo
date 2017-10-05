using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eulerGunController : MonoBehaviour {


	public string upTurnKey;
	public string downTurnKey;
	public float elevationSteps;
	private bool gUP;
	private bool gDown;

	public float moveForce = 0f;
	private Rigidbody rbody;
	public GameObject bullet;
	public float shootRate;
	public float shootForce;
	private float shootRateTime = 0f;

	public string leftTurnKey;
	public string rightTurnKey;
	public float rotationSteps;
	private bool gRight;
	private bool gLeft;
	public float bulletSpeed;

	// Use this for initialization
	void Start () {
		this.gUP = false;
		this.gDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		handleElevation ();
		handleRotation ();
		shootBall ();
	}

	private void shootBall(){
		if(Input.GetKey("u")){
			float x = this.transform.position.x * moveForce;
			float y = this.transform.position.y * moveForce;
			float z = this.transform.position.z * moveForce;
			Vector3 rbg = new Vector3(x,y+2,z);
			Quaternion rotation = Quaternion.Euler(transform.eulerAngles.x,transform.eulerAngles.y ,transform.eulerAngles.z);
			GameObject go = (GameObject)Instantiate (bullet,transform.position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			//GetComponent<Rigidbody>().velocity = transform.forward * speed;
			//rb.AddForce (rbg);
			rb.velocity = transform.forward * bulletSpeed;
		}
	}

	private void handleRotation(){
		if(Input.GetKeyDown(this.leftTurnKey)){
			gLeft = true;
		}
		if(gLeft){
			float tmp = this.transform.eulerAngles.y - rotationSteps;
			Quaternion target = Quaternion.Euler(this.transform.eulerAngles.x,tmp,this.transform.eulerAngles.z);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
		if(Input.GetKeyDown(this.rightTurnKey)){
			gRight = true;
		}
		if(gRight){
			float tmp = this.transform.eulerAngles.y - rotationSteps;
			Quaternion target = Quaternion.Euler(this.transform.eulerAngles.x,tmp,this.transform.eulerAngles.z);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
		if (Input.GetKeyUp (this.rightTurnKey) || Input.GetKeyUp(this.leftTurnKey)) {
			gRight = false;
			gLeft = false;
		}
	}

	private void handleElevation(){
		if(Input.GetKeyDown(this.downTurnKey)){
			this.gDown = true;
		}
		if(this.gDown){
			float tmp = this.transform.eulerAngles.x - elevationSteps;
			Quaternion target = Quaternion.Euler(tmp,this.transform.eulerAngles.y,this.transform.eulerAngles.z);
			this.transform.SetPositionAndRotation(this.transform.position,target);
			//transform.Rotate(new Vector3(tmp,0));
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gUP = true;
		}
		if(this.gUP){
			float tmp = this.transform.eulerAngles.x + elevationSteps;
			Quaternion target = Quaternion.Euler(tmp,this.transform.eulerAngles.y,this.transform.eulerAngles.z);
			this.transform.SetPositionAndRotation(this.transform.position,target);
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.gUP = false;
			this.gDown = false;
		}
	}
}
