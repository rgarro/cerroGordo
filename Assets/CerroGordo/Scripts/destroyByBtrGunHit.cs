using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByBtrGunHit : MonoBehaviour {

	public GameObject Blast;

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("tome chichiii...");
		if (other.tag == "Boundary") {
			return;
		}
		Instantiate (Blast,this.transform.position,this.transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
