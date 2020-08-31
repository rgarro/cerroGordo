using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                               \         .  ./
 *                            \      .:";'.:.."   /
 *                                (M^^.^~~:.'").
 *                          -   (/  .    . . \ \)  -
 *   O                         ((| :. ~ ^  :. .|))
 *  |\\                     -   (\- |  \ /  |  /)  -
 *  |  T                         -\  \     /  /-
 * / \[_]..........................\  \   /  /
 * triger object lost of altitude and final explotion
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class destroyByBtrGunHit : MonoBehaviour {

	public GameObject Blast;
	public int scoreValue = 10;
	public float stallingTime = 1.8f;
	public GameObject stallingSmoke;

	void Start(){
		this.stallingSmoke.SetActive(false);
	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("tome chichiii...");
		if (other.tag == "Boundary") {
			return;
		}
		GameObject bt = GameObject.FindGameObjectWithTag ("batiComputadora");
		batiComputadora mu = bt.GetComponent<batiComputadora> ();
		mu.addScore(scoreValue);
		this.showBlast();
		Destroy(other.gameObject);
		this.startFalling();
		Invoke("afterStall",this.stallingTime);
	}

	private void startFalling(){
		this.stallingSmoke.SetActive(true);
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.useGravity = true;
	}
	private void afterStall(){
		this.showBlast();
		Destroy(gameObject);
	}

	public void showBlast(){
		Instantiate (Blast,this.transform.position,this.transform.rotation);
	}
}
