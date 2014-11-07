using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private bool isRangedClass;
	private string playerName = "Enter Name: ";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}

	void OnGUI () {
		playerName = GUILayout.TextArea (playerName);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isRangedClass = GUILayout.Toggle (isRangedClass, "Ranged Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if (GUILayout.Button ("Create")) {
			if(isMageClass) {
				newPlayer.PlayerClass = new BaseMageClass();
			} else if(isRangedClass) {
				newPlayer.PlayerClass = new BaseRangedClass();
			} else {
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Staminia = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.PlayerName = playerName;
			storeNewPlayerInfo();
			SaveInformation.SaveAllInformation ();
			Debug.Log ("Player Name: " + newPlayer.PlayerName);
			Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log ("Player Staminia: " + newPlayer.PlayerClass.Stamina);
			Debug.Log ("Player Endurance: " + newPlayer.PlayerClass.Endurance);
			Debug.Log ("Player Intellect: " + newPlayer.PlayerClass.Intellect);
			Debug.Log ("Player Strength: " + newPlayer.PlayerClass.Strength);
		}

		if (GUILayout.Button ("Load")) {

			Application.LoadLevel ("TestScene");
		}
	}

	private void storeNewPlayerInfo() {
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Staminia = newPlayer.Staminia;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Strength = newPlayer.Strength;
	}
}
