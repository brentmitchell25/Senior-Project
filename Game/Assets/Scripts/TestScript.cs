using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		Debug.Log ("Player Name: " + GameInformation.PlayerName);
		//Debug.Log ("Player Class: " + GameInformation.PlayerClass);
		Debug.Log ("Player Level: " + GameInformation.PlayerLevel);
		Debug.Log ("Player Staminia: " + GameInformation.Staminia);
		Debug.Log ("Player Endurance: " + GameInformation.Endurance);
		Debug.Log ("Player Intellect: " + GameInformation.Intellect);
		Debug.Log ("Player Strength: " + GameInformation.Strength);
	}

}
