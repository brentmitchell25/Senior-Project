using UnityEngine;
using System.Collections;

public class SetWeapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (GameInformation.PlayerClass);
		GameObject.Find ("Sword").GetComponent<Renderer> ().enabled = false;;

		if(GameInformation.PlayerClass.ToString().Equals("BaseWarriorClass")) {
			GameObject.Find ("Sword").GetComponent<Renderer>().enabled = true;

		}

		if(GameInformation.PlayerClass.ToString().Equals("BaseRangedClass")) {
			GameObject.Find ("Sword").GetComponent<Renderer>().enabled = false;
			// Stub
		}

		if(GameInformation.PlayerClass.ToString().Equals("BaseRangedClass")) {
			GameObject.Find ("Sword").GetComponent<Renderer>().enabled = false;
			// Stub
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
