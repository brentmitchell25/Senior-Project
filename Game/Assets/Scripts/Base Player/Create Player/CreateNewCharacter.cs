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
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			newPlayer.PlayerName = playerName;
			storeNewPlayerInfo();
			createNewPlayer();
			SaveInformation.SaveAllInformation ();

		}

		if (GUILayout.Button ("Load")) {

			Application.LoadLevel ("TestScene");
		}
	}

	private void storeNewPlayerInfo() {
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Staminia = newPlayer.Stamina;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Agility = newPlayer.Agility;
		GameInformation.Resistance = newPlayer.Resistance;
		GameInformation.Gold = newPlayer.Gold;
	}

	private void createNewPlayer() {
		newPlayer.PlayerLevel = 1;
		newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
		newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
		newPlayer.Gold = 100;
		newPlayer.PlayerName = playerName;

		Debug.Log ("Player Name: " + newPlayer.PlayerName);
		Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
		Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
		Debug.Log ("Player Staminia: " + newPlayer.Stamina);
		Debug.Log ("Player Endurance: " + newPlayer.Endurance);
		Debug.Log ("Player Intellect: " + newPlayer.Intellect);
		Debug.Log ("Player Strength: " + newPlayer.Strength);
		Debug.Log ("Player Agililty: " + newPlayer.Agility);
		Debug.Log ("Player Resistance: " + newPlayer.Resistance);
		Debug.Log ("Player Gold: " + newPlayer.Gold);
	}
}
