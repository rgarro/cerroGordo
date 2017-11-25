using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByBtrGunHit : MonoBehaviour {

	public GameObject Blast;
	public int scoreValue;

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("tome chichiii...");
		if (other.tag == "Boundary") {
			return;
		}
		GameObject bt = GameObject.FindGameObjectWithTag ("batiComputadora");
		//Debug.Log (bt);
		batiComputadora mu = bt.GetComponent<batiComputadora> ();
		mu.addScore(scoreValue);
		Instantiate (Blast,this.transform.position,this.transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
