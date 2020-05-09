using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 *  December whispers are tragedy ...
 * 
 * @author Rolando <rgarro@gmail.com>
 */
public class batiComputadora : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	//public Text scoreBox;
	public int Score;
	//public dashBoard theDashBoard;
	protected string theScore;
	public GUISkin btnSkin;

	public Texture2D RestartIcon;

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

	// Use this for initialization
	void Start () {
		StartCoroutine(spawnWaves ());
		this.UpdateScore ();
		//this.theDashBoard = GameObject.AddComponent<dashBoard> as dashBoard;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUI.Label(new Rect(410,10,150,20),this.theScore);

		if (GUI.Button (new Rect (10,10, 100, 50), RestartIcon)) 
        {
            //print ("you clicked the icon");
			this.doRestart();//Confirm Box Here
        }
	}
	public void addScore(int scoreValue){
		Score += scoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		this.theScore = Score  + " points";
	}

	public void doRestart(){
		//Debug.Log("will restart");
		Application.LoadLevel(Application.loadedLevel);
	}

}
