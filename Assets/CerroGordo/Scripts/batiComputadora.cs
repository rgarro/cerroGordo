using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batiComputadora : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text scoreBox;
	public int Score;
	//public dashBoard theDashBoard;

	IEnumerator spawnWaves(){
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	//void OnGUI(){
		//Debug.Log("add component here");
		//this.theDashBoard = new dashBoard();
	//}

	// Use this for initialization
	void Start () {
		StartCoroutine(spawnWaves ());
		this.UpdateScore ();
		//this.theDashBoard = GameObject.AddComponent<dashBoard> as dashBoard;
	}

	// Update is called once per frame
	void Update () {

	}

	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.scoreBox.text = Score  + " points";
	}

	public void doRestart(){
		//Debug.Log("will restart");
		Application.LoadLevel(Application.loadedLevel);
	}

}
