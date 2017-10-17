using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByBtrGunHit : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("tome chichiii...");
		if (other.tag == "Boundary") {
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
