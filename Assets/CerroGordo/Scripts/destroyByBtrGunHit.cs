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
	public int scoreValue;

	public float stallingTime = 0.8f;
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
