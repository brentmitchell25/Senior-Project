using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name: ";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}

	void OnGUI () {
		playerName = GUILayout.TextArea (playerName);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if (GUILayout.Button ("Create")) {
			if(isMageClass) {
				newPlayer.PlayerClass = new BaseMageClass();
			} else {
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Staminia = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.PlayerName = playerName;

			Debug.Log ("Player Name: " + newPlayer.PlayerName);
			Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log ("Player Staminia: " + newPlayer.PlayerClass.Stamina);
			Debug.Log ("Player Endurance: " + newPlayer.PlayerClass.Endurance);
			Debug.Log ("Player Intellect: " + newPlayer.PlayerClass.Intellect);
			Debug.Log ("Player Strength: " + newPlayer.PlayerClass.Strength);
		}
	}
}
